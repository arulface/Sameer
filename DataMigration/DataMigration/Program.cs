using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnection connection_src;
            IConnection connection_des;
            ConfigurationReader configurationReader = new ConfigurationReader();
            var configurations = configurationReader.GetConfigurationDetails("Test");
            string json_src = configurations[0].ConfiguredValue;
            dynamic configValue_src = JsonConvert.DeserializeObject<dynamic>(json_src);
            connection_src  = ConnectionFactory.GetDestinationTypeInstance(configValue_src.Type.Value, json_src);
            object connectionObject_src = connection_src.OpenConnection();
            string json_des = configurations[1].ConfiguredValue;
            dynamic configValue_des = JsonConvert.DeserializeObject<dynamic>(json_des);
            connection_des = ConnectionFactory.GetDestinationTypeInstance(configValue_des.Type.Value, json_des);
            object connectionObject_des = connection_des.OpenConnection();
            foreach (var config in configurations.Skip(2))
            {
                
            }
            
        }
    }
}
