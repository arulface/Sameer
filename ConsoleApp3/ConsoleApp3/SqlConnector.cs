using ConsoleApp3.Helper;
using ConsoleApp3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SqlConnector : IConnection
    {
        private readonly SQL_Properties _sqlProperties;
        public SqlConnector()
        {
            _sqlProperties = GetSqlProperties();
        }

        private SQL_Properties GetSqlProperties()
        {
            string jsonFilePath = Path.Combine(AppHelper.GetJsonDirectoryPath(), JsonFile.SQL_JSON);
            string Json = System.IO.File.ReadAllText(jsonFilePath);
            SQL_Properties sql_Properties = JsonConvert.DeserializeObject<SQL_Properties>(Json);
            return sql_Properties;
        }

        public bool GetData()
        {
            bool isWritten = false;
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;",_sqlProperties.Server,_sqlProperties.Database);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                //log
            }
            finally
            {
                connection.Close();
            }
            return isWritten;
        }
    }
}
