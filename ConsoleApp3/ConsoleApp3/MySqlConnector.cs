﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MySqlConnector : IConnection
    {
        private readonly string _constr;
        public MySqlConnector(string constr)
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
