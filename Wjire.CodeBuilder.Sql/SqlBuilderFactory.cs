using System;

namespace Wjire.CodeBuilder.Sql
{
    public class SqlBuilderFactory
    {
        public static ISqlBuilder Create(string type)
        {
            switch (type.ToLower())
            {
                case "sqlserver":
                    return new SqlServerBuilder();
                case "mysql":
                    return new MySqlBuilder();
                default:
                    throw new Exception("尚不支持 " + type);
            }
        }
    }
}
