using DataMigration.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    public class SqlConnector : IConnection
    {

        private readonly DBProperties _dbProperties;
        public SqlConnector(string dbPropertiesJson)
        {
            _dbProperties = JsonConvert.DeserializeObject<DBProperties>(dbPropertiesJson);
        }

        public void CloseConnection(object connectionObject)
        {
            (connectionObject as SqlConnection).Close();
        }

        public bool ExecuteNonQuery(object connectionObject, string query)
        {
            throw new NotImplementedException();
        }

        public DataSet GetMultipleResultSet(object connectionObject, string query)
        {
            throw new NotImplementedException();
        }

        public object OpenConnection()
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;", _dbProperties.Server, _dbProperties.Database);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
