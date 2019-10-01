using ConsoleApp3.Helper;
using ConsoleApp3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FileConnector : IConnection
    {
        private readonly File_Properties _fileProperties;
        public FileConnector()
        {
            _fileProperties = GetFileProperties();
        }

        private File_Properties GetFileProperties()
        {
            string jsonFilePath = Path.Combine(AppHelper.GetJsonDirectoryPath(),JsonFile.FILE_JSON);
            string Json = System.IO.File.ReadAllText(jsonFilePath);
            File_Properties file_Properties = JsonConvert.DeserializeObject<File_Properties>(Json);
            return file_Properties;
        }


        public bool GetData()
        {
            bool isWritten = false;
            string[] lines = File.ReadAllLines(_fileProperties.FilePath);
            foreach (string line in lines)
                Console.WriteLine(line);
            return isWritten;
        }

    }
}
