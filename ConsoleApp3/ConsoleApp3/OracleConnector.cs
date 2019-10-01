using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class OracleConnector : IConnection
    {
        private readonly string _constr;
        public OracleConnector(string constr)
        {
            _constr = constr;
        }
        public bool GetData()
        {
            bool isWritten = false;
            return isWritten;
        }
    }
}
