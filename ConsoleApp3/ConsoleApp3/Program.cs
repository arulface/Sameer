using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Application Started");
                string type = "Sql";
                ConnectionFactory.GetDestinationTypeInstance(type).GetData();
                Console.WriteLine("Execution Done");
                Console.ReadLine();
            }
            catch (Exception err)
            {
                //log
            }
        }
    }
}
