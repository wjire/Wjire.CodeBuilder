using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Newtonsoft.Json;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.cs_Builder;
using Wjire.CodeBuilder.csproj_Builder;
using Wjire.CodeBuilder.DbService;
using Wjire.CodeBuilder.FileService;
using Wjire.CodeBuilder.Model;
using Wjire.CodeBuilder.Sql;
using Wjire.CodeBuilder.Util;

namespace Wjire.CodeBuilder
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<string, ConnectionInfo> _connectionInfos = new Dictionary<string, ConnectionInfo>();
        private IDbService _dbService;
        private ISqlBuilder _sqlBuilder;
        private string _dbType = "sqlserver";

        public Form1()
        {
            InitializeComponent();
            _sqlBuilder = SqlBuilderFactory.Create(_dbType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitConnectionInfos();
            InitTextBox_CodePath();
            InitDbTypes();
        }


        /// <summary>
        /// 切换数据库类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_dbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dbType = comboBox_dbType.Text;
            _sqlBuilder = SqlBuilderFactory.Create(_dbType);
        }


        /// <summary>
        /// 连接到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_one_conn_Click(object sender, EventArgs e)
        {
            comboBox_one_dataBase.Items.Clear();
            comboBox_one_dataBase.Text = string.Empty;
            Clear();
            ConnectionInfo info = GetCurrentConnectionInfo();
            _dbService = DbServiceFactory.CreateDbService(info);
            List<string> dbList = await _dbService.GetAllDataBase();
            BindDataBase(dbList);
            GetTableNames();
            AddConnectionInfoToCombox(info);
            AddConnectionInfoToCache(info);
            SaveConnectionInfoToResource();
        }


        /// <summary>
        /// 填充数据库下拉
        /// </summary>
        /// <param name="list"></param>
        private void BindDataBase(List<string> list)
        {
            foreach (string item in list)
            {
                comboBox_one_dataBase.Items.Add(item);
            }
            comboBox_one_dataBase.Text = _dbService.ConnectionInfo.DbName;
        }



        /// <summary>
        /// 切换IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_IP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_IP.SelectedIndex < 0)
            {
                return;
            }
            ConnectionInfo connectionInfo = _connectionInfos[comboBox_IP.Text];
            SetConnectionInfoToView(connectionInfo);
        }



        /// <summary>
        /// 切换数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_one_dataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_one_dataBase.SelectedIndex < 0)
            {
                return;
            }
            textBox_dbName.Text = comboBox_one_dataBase.Text;
            ConnectionInfo info = GetCurrentConnectionInfo();
            _dbService = DbServiceFactory.CreateDbService(info);
            GetTableNames();
        }



        /// <summary>
        /// 根据数据库名获取所有表名
        /// </summary>
        private async void GetTableNames()
        {
            List<string> list = await _dbService.GetTableNames();
            Clear();
            int index = 1;
            foreach (string item in list)
            {
                listView_one_tables.Items.Add(new ListViewItem(new[] { index++.ToString(), item }));
            }
        }



        /// <summary>
        /// 选中表,获取该表的字段信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void listView_one_tables_Click(object sender, EventArgs e)
        {
            if (listView_one_tables.SelectedItems.Count != 1)
            {
                return;
            }

            ListViewItem selectedItem = listView_one_tables.SelectedItems[0];
            string tableName = selectedItem.SubItems[1].Text;
            List<TableInfo> list = await _dbService.GetTableInfo(tableName);
            textBox_result.Text = new Cs_EntityBuilder(list).GetContent(GetCurrentFormInfo(tableName));
            listView_one_tableStruct.Items.Clear();
            int index = 1;
            foreach (TableInfo item in list)
            {
                listView_one_tableStruct.Items.Add(new ListViewItem(new string[]
                {
                    index++.ToString(),
                    item.ColumnName,
                    item.ColumnType,
                    item.ColumnDescription,
                    item.IsKey,
                    item.IsNullable,
                }));
            }
        }


        /// <summary>
        /// 多选表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_one_tables_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected = e.Item.Checked;
        }



        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_toAll_Click(object sender, EventArgs e)
        {
            Sln_Builder slnBuilder = new Sln_Builder();
            slnBuilder.AddCsprojBuilder(new Csproj_WebApiBuilder(new List<Cs_AbstractBuilder>
            {
                new Cs_ProgramBuilder(),
                new Cs_StartupBuilder(),
                new Cs_AppsettingsBuilder(),
                new Cs_AppsettingsDevBuilder(),
                new Cs_ServicesExtensionBuilder(),
            }));
            slnBuilder.AddCsprojBuilder(new Csproj_LogicBuilder());
            slnBuilder.AddCsprojBuilder(new Csproj_DTOBuilder());
            slnBuilder.AddCsprojBuilder(new Csproj_RepositoryBuilder(new List<Cs_AbstractBuilder>
            {
                new Cs_DbFactoryBuilder()
            }));
            slnBuilder.AddCsprojBuilder(new Csproj_EntityBuilder());

            FormInfo formInfo = GetCurrentFormInfo();
            slnBuilder.CreateFile(formInfo);

            Cs_ControllerBuilder controllerBuilder = new Cs_ControllerBuilder();
            Cs_LogicBuilder logicBuilder = new Cs_LogicBuilder();
            Cs_RepositoryBuilder repositoryBuilder = new Cs_RepositoryBuilder();
            Cs_RepositoryFactoryBuilder repositoryFactoryBuilder = new Cs_RepositoryFactoryBuilder();

            foreach (ListViewItem selectedItem in listView_one_tables.SelectedItems)
            {
                formInfo.TableName = selectedItem.SubItems[1].Text;
                List<TableInfo> list = _dbService.GetTableInfo(formInfo.TableName).Result;
                Cs_EntityBuilder entityBuilder = new Cs_EntityBuilder(list);
                entityBuilder.CreateFile(formInfo);

                controllerBuilder.CreateFile(formInfo);
                logicBuilder.CreateFile(formInfo);
                repositoryBuilder.CreateFile(formInfo);
                repositoryFactoryBuilder.CreateFile(formInfo);
            }

            OpenCurrentNameSpaceFileFolder();
        }



        /// <summary>
        /// 选择自定义 excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ChooseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "请选择文件",
                Filter = "excel文件|*.xls",
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_excelPath.Text = fileDialog.FileName;
            }
        }



        /// <summary>
        /// 生成创建数据库表的sql语句
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreateTableSql_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_excelPath.Text))
            {
                OpenMessageBox("请选择 excel 文件");
                return;
            }
            string entityName = Path.GetFileNameWithoutExtension(textBox_excelPath.Text);
            string text = _sqlBuilder.Create(textBox_excelPath.Text, entityName);
            string savePath = Path.Combine(Path.GetDirectoryName(textBox_excelPath.Text), $"{entityName}.sql");
            File.WriteAllText(savePath, text);
            Process.Start("notepad.exe", savePath);
        }



        /// <summary>
        /// 编辑模板文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_editCodeTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TemplatePath.BasePath), "txt文件|*.txt");
        }



        /// <summary>
        /// 下载excel模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_openTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TemplatePath.BasePath + "\\" + TemplatePath.Excel), "excel文件|*.xls");
        }


        private void Clear()
        {
            listView_one_tables.Items.Clear();
            listView_one_tableStruct.Items.Clear();
            textBox_result.Text = string.Empty;
        }


        private void InitConnectionInfos()
        {
            LoadConnectionInfoFromResource();
            foreach (KeyValuePair<string, ConnectionInfo> info in _connectionInfos)
            {
                comboBox_IP.Items.Add(info.Key);
            }
            comboBox_IP.Text = _connectionInfos.Keys.FirstOrDefault() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(comboBox_IP.Text))
            {
                return;
            }

            ConnectionInfo connectionInfo = _connectionInfos[comboBox_IP.Text];
            SetConnectionInfoToView(connectionInfo);
        }


        private void SetConnectionInfoToView(ConnectionInfo connectionInfo)
        {
            if (connectionInfo == null)
            {
                return;
            }
            textBox_one_user.Text = connectionInfo.User;
            textBox_dbName.Text = connectionInfo.DbName;
            textBox_one_pwd.Text = connectionInfo.Pwd;
        }


        private void InitTextBox_CodePath()
        {
            string codePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Code");
            if (Directory.Exists(codePath) == false)
            {
                Directory.CreateDirectory(codePath);
            }
            textBox_codePath.Text = codePath;
        }


        private void InitDbTypes()
        {
            comboBox_dbType.Items.Add("sqlserver");
            comboBox_dbType.Items.Add("mysql");
            comboBox_dbType.Text = _dbType;
        }


        private ConnectionInfo GetCurrentConnectionInfo()
        {
            ConnectionInfo connectionInfo = new ConnectionInfo
            {
                DbName = textBox_dbName.Text,
                User = textBox_one_user.Text,
                Pwd = textBox_one_pwd.Text,
                IP = comboBox_IP.Text,
                Type = _dbType,
            };
            return connectionInfo;
        }


        private void AddConnectionInfoToCombox(ConnectionInfo info)
        {
            if (comboBox_IP.Items.Contains(info.IP) == false)
            {
                comboBox_IP.Items.Add(info.IP);
            }
        }


        private void AddConnectionInfoToCache(ConnectionInfo info)
        {
            if (_connectionInfos.ContainsKey(info.IP))
            {
                _connectionInfos[info.IP] = info;
            }
            else
            {
                _connectionInfos.Add(info.IP, info);
            }
        }



        private void SaveConnectionInfoToResource()
        {
            using (ResXResourceWriter writer = new ResXResourceWriter("Resource.resx"))
            {
                foreach (KeyValuePair<string, ConnectionInfo> keyValue in _connectionInfos)
                {
                    string json = JsonConvert.SerializeObject(keyValue.Value);
                    writer.AddResource(keyValue.Key, json);
                }
            }
        }


        private void LoadConnectionInfoFromResource()
        {
            using (ResXResourceReader reader = new ResXResourceReader("Resource.resx"))
            {
                try
                {
                    IDictionaryEnumerator iter = reader.GetEnumerator();
                    while (iter.MoveNext())
                    {
                        ConnectionInfo value = JsonConvert.DeserializeObject<ConnectionInfo>(iter.Value.ToString());
                        _connectionInfos.Add(iter.Key.ToString(), value);
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }


        private void button_choosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "请选择要保存的路径",
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                MessageBox.Show(this, "文件夹路径不能为空", "提示");
                return;
            }

            textBox_codePath.Text = dialog.SelectedPath;
        }


        private void OpenFileDialog(string dir, string filter = null, string process = null)
        {
            FileHelper.CheckDirectory(dir);
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "请选择文件",
                Filter = filter,
                InitialDirectory = dir,
            };
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(process))
            {
                Process.Start(fileDialog.FileName);
            }
            else
            {
                Process.Start(process, fileDialog.FileName);
            }
        }


        private void button_toNamespace_Click(object sender, EventArgs e)
        {
            OpenCurrentNameSpaceFileFolder();
        }

        private void OpenCurrentNameSpaceFileFolder()
        {
            OpenFileDialog(Path.Combine(textBox_codePath.Text, textBox_namespace.Text));
        }


        private void OpenMessageBox(string msg)
        {
            MessageBox.Show(msg);
        }


        private FormInfo GetCurrentFormInfo(string tableName = null)
        {
            return new FormInfo
            {
                BasePath = Path.Combine(textBox_codePath.Text, textBox_namespace.Text),
                NameSpaceName = textBox_namespace.Text,
                DbName = textBox_dbName.Text,
                TableName = string.IsNullOrWhiteSpace(tableName) ? string.Empty : tableName,
                Pwd = textBox_one_pwd.Text,
            };
        }
    }
}
