using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.Model
{
    public class Configuration
    {
        public string ConfigurationFilter { get; set; }
        public string ConfiguredName { get; set; }
        public string ConfiguredValue { get; set; }
        public string ConfigurationSrcDest { get; set; }
    }
}
