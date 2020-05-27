using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.Sql
{
    public class MySqlBuilder : ISqlBuilder
    {

        /// <summary>
        /// 生成 数据库创建表的sql语句
        /// </summary>
        /// <param name="path">excel路径</param>
        /// <param name="entityName">实体名称</param>
        /// <returns></returns>
        public string Create(string path, string entityName)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            Excel.ExcelReadHandler excel = new Excel.ExcelReadHandler(path);
            List<string> keys = new List<string>();
            List<TableInfo> tableList = excel.Read<TableInfo>(typeof(TableInfo).GetProperties().Select(s => s.Name).ToArray()).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CREATE TABLE {entityName} (");
            foreach (TableInfo table in tableList)
            {
                if (table.IsKey == "1")
                {
                    keys.Add(table.ColumnName);
                }
                sb.AppendLine($" {table.ColumnName} {table.ColumnType}{GetLength(table.ColumnLength)} {GetCharacter(table)} {GetNullable(table)} COMMENT '{table.ColumnDescription}',");
            }
            if (keys.Count > 0)
            {
                sb.AppendLine($"PRIMARY KEY ({string.Join(",", keys)}),");
            }
            sb = sb.Remove(sb.Length - 3, 1);
            sb.AppendLine(")");
            sb.AppendLine(" ENGINE=InnoDB DEFAULT CHARSET=utf8;");
          
            return sb.ToString();
        }


        private string GetSortRule(string type)
        {
            type = type.Trim().ToLower();
            if (type.Contains("char"))
            {
                return "COLLATE Chinese_PRC_CI_AS";
            }
            return null;
        }

        private string GetCharacter(TableInfo tableInfo)
        {
            if (IsString(tableInfo.ColumnType))
            {
                return " CHARACTER SET utf8 COLLATE utf8_general_ci ";
            }
            return null;
        }

        private string GetLength(string length)
        {
            return string.IsNullOrWhiteSpace(length) ? null : $"({length})";
        }

        private string GetNullable(TableInfo tableInfo)
        {
            var result = string.Empty;
            if (tableInfo.IsKey == "1")
            {
                result += " NOT NULL ";
                if (tableInfo.IsIncrement == "1")
                {
                    result += " AUTO_INCREMENT ";
                }
                return result;
            }

            if (tableInfo.IsNullable == "1")
            {
                result += " DEFAULT NULL ";
            }
            else
            {
                result += " NOT NULL ";
                if (IsString(tableInfo.ColumnType))
                {
                    result += " DEFAULT '' ";
                }
            }
            return result;
        }


        private bool IsString(string columnType)
        {
            switch (columnType.ToLower())
            {
                case "char":
                case "varchar":
                case "text":
                case "tinytext":
                case "mediumtext":
                case "longtext":
                    return true;
                default:
                    return false;
            }
        }
    }
}
