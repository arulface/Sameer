using DataMigration.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    public class FileConnector : IConnection
    {
        private readonly FileProperties _fileProperties;
        public FileConnector(string filePropertiesJson)
        {
            _fileProperties = JsonConvert.DeserializeObject<FileProperties>(filePropertiesJson);
        }
        public void CloseConnection(object connectionObject)
        {
            StreamReader streamReader = connectionObject as StreamReader;
            streamReader.Close();
            streamReader.Dispose();
        }

        public bool ExecuteNonQuery(object connectionObject, string query)
        {
            throw new NotImplementedException();
        }

        public DataSet GetMultipleResultSet(object connectionObject, string query)
        {
            StreamReader streamReader = connectionObject as StreamReader;
           var content =  streamReader.ReadToEnd();
            throw new NotImplementedException();
        }

        public object OpenConnection()
        {
            StreamReader reader = new StreamReader(_fileProperties.FilePath);
            return reader;
        }
    }
}
