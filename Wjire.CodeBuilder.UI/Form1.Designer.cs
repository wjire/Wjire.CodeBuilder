﻿namespace Wjire.CodeBuilder
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_toNamespace = new System.Windows.Forms.Button();
            this.button_choosePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_codePath = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.comboBox_dbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_IP = new System.Windows.Forms.ComboBox();
            this.button_toAll = new System.Windows.Forms.Button();
            this.button_openTemplate = new System.Windows.Forms.Button();
            this.textBox_excelPath = new System.Windows.Forms.TextBox();
            this.button_CreateTableSql = new System.Windows.Forms.Button();
            this.button_ChooseExcel = new System.Windows.Forms.Button();
            this.textBox_dbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_one_dataBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_one_tableStruct = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_one_tables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_one_conn = new System.Windows.Forms.Button();
            this.textBox_one_pwd = new System.Windows.Forms.TextBox();
            this.textBox_one_user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_toNamespace);
            this.groupBox1.Controls.Add(this.button_choosePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_codePath);
            this.groupBox1.Controls.Add(this.textBox_result);
            this.groupBox1.Controls.Add(this.comboBox_dbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_IP);
            this.groupBox1.Controls.Add(this.button_toAll);
            this.groupBox1.Controls.Add(this.button_openTemplate);
            this.groupBox1.Controls.Add(this.textBox_excelPath);
            this.groupBox1.Controls.Add(this.button_CreateTableSql);
            this.groupBox1.Controls.Add(this.button_ChooseExcel);
            this.groupBox1.Controls.Add(this.textBox_dbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_one_dataBase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_one_conn);
            this.groupBox1.Controls.Add(this.textBox_one_pwd);
            this.groupBox1.Controls.Add(this.textBox_one_user);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1428, 734);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button_toNamespace
            // 
            this.button_toNamespace.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_toNamespace.Location = new System.Drawing.Point(1213, 698);
            this.button_toNamespace.Name = "button_toNamespace";
            this.button_toNamespace.Size = new System.Drawing.Size(122, 24);
            this.button_toNamespace.TabIndex = 37;
            this.button_toNamespace.Text = "打开文件夹";
            this.button_toNamespace.UseVisualStyleBackColor = true;
            this.button_toNamespace.Click += new System.EventHandler(this.button_toNamespace_Click);
            // 
            // button_choosePath
            // 
            this.button_choosePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_choosePath.Location = new System.Drawing.Point(1077, 698);
            this.button_choosePath.Name = "button_choosePath";
            this.button_choosePath.Size = new System.Drawing.Size(130, 24);
            this.button_choosePath.TabIndex = 34;
            this.button_choosePath.Text = "选择文件夹";
            this.button_choosePath.UseVisualStyleBackColor = true;
            this.button_choosePath.Click += new System.EventHandler(this.button_choosePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(328, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "文件路径:";
            // 
            // textBox_codePath
            // 
            this.textBox_codePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_codePath.Location = new System.Drawing.Point(429, 698);
            this.textBox_codePath.Name = "textBox_codePath";
            this.textBox_codePath.Size = new System.Drawing.Size(642, 23);
            this.textBox_codePath.TabIndex = 32;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_result.Location = new System.Drawing.Point(955, 137);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(467, 539);
            this.textBox_result.TabIndex = 23;
            // 
            // comboBox_dbType
            // 
            this.comboBox_dbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dbType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_dbType.FormattingEnabled = true;
            this.comboBox_dbType.Location = new System.Drawing.Point(57, 22);
            this.comboBox_dbType.Name = "comboBox_dbType";
            this.comboBox_dbType.Size = new System.Drawing.Size(97, 24);
            this.comboBox_dbType.TabIndex = 29;
            this.comboBox_dbType.SelectedIndexChanged += new System.EventHandler(this.comboBox_dbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "类型:";
            // 
            // comboBox_IP
            // 
            this.comboBox_IP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_IP.FormattingEnabled = true;
            this.comboBox_IP.Location = new System.Drawing.Point(246, 24);
            this.comboBox_IP.Name = "comboBox_IP";
            this.comboBox_IP.Size = new System.Drawing.Size(171, 24);
            this.comboBox_IP.TabIndex = 27;
            this.comboBox_IP.Text = "localhost";
            this.comboBox_IP.SelectedIndexChanged += new System.EventHandler(this.comboBox_IP_SelectedIndexChanged);
            // 
            // button_toAll
            // 
            this.button_toAll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_toAll.Location = new System.Drawing.Point(1341, 698);
            this.button_toAll.Name = "button_toAll";
            this.button_toAll.Size = new System.Drawing.Size(77, 24);
            this.button_toAll.TabIndex = 26;
            this.button_toAll.Text = "Build";
            this.button_toAll.UseVisualStyleBackColor = true;
            this.button_toAll.Click += new System.EventHandler(this.button_toAll_Click);
            // 
            // button_openTemplate
            // 
            this.button_openTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_openTemplate.Location = new System.Drawing.Point(256, 62);
            this.button_openTemplate.Name = "button_openTemplate";
            this.button_openTemplate.Size = new System.Drawing.Size(129, 31);
            this.button_openTemplate.TabIndex = 26;
            this.button_openTemplate.Text = "下载excel模板";
            this.button_openTemplate.UseVisualStyleBackColor = true;
            this.button_openTemplate.Click += new System.EventHandler(this.button_openTemplate_Click);
            // 
            // textBox_excelPath
            // 
            this.textBox_excelPath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_excelPath.Location = new System.Drawing.Point(532, 68);
            this.textBox_excelPath.Name = "textBox_excelPath";
            this.textBox_excelPath.Size = new System.Drawing.Size(742, 23);
            this.textBox_excelPath.TabIndex = 24;
            // 
            // button_CreateTableSql
            // 
            this.button_CreateTableSql.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CreateTableSql.Location = new System.Drawing.Point(1275, 62);
            this.button_CreateTableSql.Name = "button_CreateTableSql";
            this.button_CreateTableSql.Size = new System.Drawing.Size(147, 31);
            this.button_CreateTableSql.TabIndex = 17;
            this.button_CreateTableSql.Text = "生成sql建表语句";
            this.button_CreateTableSql.UseVisualStyleBackColor = true;
            this.button_CreateTableSql.Click += new System.EventHandler(this.button_CreateTableSql_Click);
            // 
            // button_ChooseExcel
            // 
            this.button_ChooseExcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ChooseExcel.Location = new System.Drawing.Point(391, 62);
            this.button_ChooseExcel.Name = "button_ChooseExcel";
            this.button_ChooseExcel.Size = new System.Drawing.Size(128, 31);
            this.button_ChooseExcel.TabIndex = 16;
            this.button_ChooseExcel.Text = "选择excel文件:";
            this.button_ChooseExcel.UseVisualStyleBackColor = true;
            this.button_ChooseExcel.Click += new System.EventHandler(this.button_ChooseExcel_Click);
            // 
            // textBox_dbName
            // 
            this.textBox_dbName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_dbName.Location = new System.Drawing.Point(521, 22);
            this.textBox_dbName.Name = "textBox_dbName";
            this.textBox_dbName.Size = new System.Drawing.Size(173, 26);
            this.textBox_dbName.TabIndex = 13;
            this.textBox_dbName.Text = "master";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(437, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据库名:";
            // 
            // comboBox_one_dataBase
            // 
            this.comboBox_one_dataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_one_dataBase.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_one_dataBase.FormattingEnabled = true;
            this.comboBox_one_dataBase.Location = new System.Drawing.Point(81, 66);
            this.comboBox_one_dataBase.Name = "comboBox_one_dataBase";
            this.comboBox_one_dataBase.Size = new System.Drawing.Size(157, 24);
            this.comboBox_one_dataBase.TabIndex = 11;
            this.comboBox_one_dataBase.SelectedIndexChanged += new System.EventHandler(this.comboBox_one_dataBase_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据库:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_one_tableStruct);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(322, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 564);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "表结构";
            // 
            // listView_one_tableStruct
            // 
            this.listView_one_tableStruct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_one_tableStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_one_tableStruct.FullRowSelect = true;
            this.listView_one_tableStruct.GridLines = true;
            this.listView_one_tableStruct.HideSelection = false;
            this.listView_one_tableStruct.Location = new System.Drawing.Point(3, 22);
            this.listView_one_tableStruct.Name = "listView_one_tableStruct";
            this.listView_one_tableStruct.Size = new System.Drawing.Size(612, 539);
            this.listView_one_tableStruct.TabIndex = 0;
            this.listView_one_tableStruct.UseCompatibleStateImageBehavior = false;
            this.listView_one_tableStruct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "序号";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "字段名";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "字段类型";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "字段注释";
            this.columnHeader6.Width = 320;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_one_tables);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(10, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 611);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表集合";
            // 
            // listView_one_tables
            // 
            this.listView_one_tables.CheckBoxes = true;
            this.listView_one_tables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_one_tables.FullRowSelect = true;
            this.listView_one_tables.GridLines = true;
            this.listView_one_tables.HideSelection = false;
            this.listView_one_tables.Location = new System.Drawing.Point(6, 20);
            this.listView_one_tables.Name = "listView_one_tables";
            this.listView_one_tables.Size = new System.Drawing.Size(296, 591);
            this.listView_one_tables.TabIndex = 0;
            this.listView_one_tables.UseCompatibleStateImageBehavior = false;
            this.listView_one_tables.View = System.Windows.Forms.View.Details;
            this.listView_one_tables.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_one_tables_ItemChecked);
            this.listView_one_tables.Click += new System.EventHandler(this.listView_one_tables_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "表名称";
            this.columnHeader2.Width = 240;
            // 
            // button_one_conn
            // 
            this.button_one_conn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_one_conn.Location = new System.Drawing.Point(1275, 19);
            this.button_one_conn.Name = "button_one_conn";
            this.button_one_conn.Size = new System.Drawing.Size(147, 29);
            this.button_one_conn.TabIndex = 6;
            this.button_one_conn.Text = "连接数据库";
            this.button_one_conn.UseVisualStyleBackColor = true;
            this.button_one_conn.Click += new System.EventHandler(this.button_one_conn_Click);
            // 
            // textBox_one_pwd
            // 
            this.textBox_one_pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_one_pwd.Location = new System.Drawing.Point(1030, 22);
            this.textBox_one_pwd.Name = "textBox_one_pwd";
            this.textBox_one_pwd.PasswordChar = '●';
            this.textBox_one_pwd.Size = new System.Drawing.Size(221, 26);
            this.textBox_one_pwd.TabIndex = 5;
            this.textBox_one_pwd.Text = "Aa1111";
            // 
            // textBox_one_user
            // 
            this.textBox_one_user.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_one_user.Location = new System.Drawing.Point(784, 22);
            this.textBox_one_user.Name = "textBox_one_user";
            this.textBox_one_user.Size = new System.Drawing.Size(175, 26);
            this.textBox_one_user.TabIndex = 4;
            this.textBox_one_user.Text = "sa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(160, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "连接地址:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(973, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "密码:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(714, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "用户名:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 734);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "代码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_dbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_one_tables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_one_conn;
        private System.Windows.Forms.TextBox textBox_one_pwd;
        private System.Windows.Forms.TextBox textBox_one_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_ChooseExcel;
        private System.Windows.Forms.Button button_CreateTableSql;
        private System.Windows.Forms.TextBox textBox_excelPath;
        private System.Windows.Forms.Button button_openTemplate;
        private System.Windows.Forms.Button button_toAll;
        private System.Windows.Forms.ComboBox comboBox_IP;
        protected internal System.Windows.Forms.ComboBox comboBox_one_dataBase;
        private System.Windows.Forms.ComboBox comboBox_dbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView_one_tableStruct;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button_choosePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codePath;
        private System.Windows.Forms.Button button_toNamespace;
    }
}

