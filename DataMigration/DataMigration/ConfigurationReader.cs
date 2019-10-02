using DataMigration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    public class ConfigurationReader
    {
        public List<Configuration> GetConfigurationDetails(string filter)
        {
            List<Configuration> configurations = new List<Configuration>();
            configurations.Add(new Configuration() { ConfigurationFilter = "Test", ConfiguredName = "TestTable1", ConfiguredValue = "{'Type': 'File','Filepath': 'E:\\\\GBRIT\\\\Upwork\\\\Sameer\\\\TestFile\\\\Sample.txt','FileName': 'Sample.txt','Delimeter': '|'}", ConfigurationSrcDest = "FILE_SRC" });
            configurations.Add(new Configuration() { ConfigurationFilter = "Test", ConfiguredName = "TestTable1", ConfiguredValue = "{'Type': 'Sql','Server': 'VIGNESH\\\\SQLEXPRESS','Database': 'Test'}", ConfigurationSrcDest = "SQL_DES" });
            return configurations;
        }
    }
}
