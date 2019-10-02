using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    public class AppData
    {
        public static List<string> ConfigurationSrcDests = new List<string>() { "FILE_SRC", "SQL_DES", "SQL_SRC" };
    }

    public class DestinationType
    {
        public const string MYSQL = "MySql";
        public const string MSSQL = "Sql";
        public const string ORACLE = "Oracle";
        public const string FILE = "File";
    }
}
