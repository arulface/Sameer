using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Helper
{
    public class AppHelper
    {
        private AppHelper()
        {

        }

        public static string GetJsonDirectoryPath()
        {
            string path = "";
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            path = Uri.UnescapeDataString(uri.Path);
            path = Path.Combine(Path.GetDirectoryName(path), "Json");
            return path;
        }
    }
}
