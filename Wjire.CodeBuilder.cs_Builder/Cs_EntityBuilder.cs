using System.Collections.Generic;
using System.IO;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.Model;
using Wjire.CodeBuilder.Util;

namespace Wjire.CodeBuilder.cs_Builder
{

    /// <summary>
    /// 实体创建,单独的逻辑,不继承任何类
    /// </summary>
    public class Cs_EntityBuilder : Cs_AbstractBuilder
    {

        private readonly List<TableInfo> _tableInfos;


        public Cs_EntityBuilder(List<TableInfo> tableInfos)
        {
            _tableInfos = tableInfos;
        }

        public string GetContent(FormInfo formInfo)
        {
            return CreateContent(formInfo);
        }

        protected override string CreateContent(FormInfo formInfo)
        {
            MyStringBuilder fieldBuilder = new MyStringBuilder(256);
            foreach (TableInfo tableInfo in _tableInfos)
            {
                string columnDescription = tableInfo.ColumnDescription;
                string keyString = null;
                string typeName = ChangeToCSharpType(tableInfo.ColumnType);
                string name = tableInfo.ColumnName;
                name = name.Substring(0, 1).ToUpper() + name.Substring(1);
                string isNullable = tableInfo.IsNullable == "1" && typeName != "string" ? "?" : "";
                if (tableInfo.IsIncrement == "1")
                {
                    keyString = "[Key]";
                }
                fieldBuilder.AppendLine();
                fieldBuilder.AppendLine(2, "/// <summary>");
                fieldBuilder.AppendLine(2, $"/// {columnDescription}");
                fieldBuilder.AppendLine(2, "/// </summary>");
                if (string.IsNullOrWhiteSpace(keyString) == false)
                {
                    fieldBuilder.AppendLine(2, keyString);
                }
                fieldBuilder.AppendLine(2, "public " + typeName + isNullable + " " + name + " { " + "get; set;" + " }");
                fieldBuilder.AppendLine();
            }

            string[] textArray = File.ReadAllLines(GetTemplateFromPath());
            MyStringBuilder sb = new MyStringBuilder(128);
            foreach (string text in textArray)
            {
                string item = text.Replace(TemplatePlaceholder.NameSpaceName, formInfo.NameSpaceName).Replace(TemplatePlaceholder.TableName, formInfo.TableName);
                if (item.Trim() == TemplatePlaceholder.FieldArea)
                {
                    string temp = item.Replace(item, fieldBuilder.ToString());
                    sb.AppendLine(temp);
                }
                else
                {
                    sb.AppendLine(item);
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// 数据库中与C#中的数据类型对照
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string ChangeToCSharpType(string type)
        {
            switch (type.ToLower())
            {
                case "int":
                case "tinyint":
                case "smallint":
                    return "int";
                case "bigint":
                    return "long";
                case "bit":
                    return "bool";
                case "decimal":
                case "money":
                case "numeric":
                case "smallmoney":
                    return "decimal";
                case "float":
                    return "double";
                case "real":
                    return "Single";
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    return "string";
                case "binary":
                case "image":
                case "varbinary":
                    return "byte[]";
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                case "timestamp":
                    return "DateTime";
                case "uniqueidentifier":
                    return "Guid";
                case "Variant":
                    return "object";
                default:
                    return "string";
            }
        }


        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Entity.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Entity\\{formInfo.TableName}.cs");
        }
    }
}
