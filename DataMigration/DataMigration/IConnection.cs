using DataMigration.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    public interface IConnection
    {
        object OpenConnection();
        bool ExecuteNonQuery(object connectionObject, string query);
        DataSet GetMultipleResultSet(object connectionObject, string query);
        void CloseConnection(object connectionObject);
    }
}
