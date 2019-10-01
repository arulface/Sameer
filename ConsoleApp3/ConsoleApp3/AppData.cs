using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DestinationType
    {
        public const string MYSQL = "MySql";
        public const string MSSQL = "Sql";
        public const string ORACLE = "Oracle";
        public const string FILE = "File";
    }

    public class JsonFile
    {
        public const string SQL_JSON = "SQL.json";
        public const string FILE_JSON = "File.json";
        public const string MSSQL_JSON = "MsSql.json";
        public const string ORACLE_JSON = "Oracle.json";
    }
}
