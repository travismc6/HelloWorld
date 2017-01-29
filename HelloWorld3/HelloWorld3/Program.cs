using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorld3
{
    class Program
    {
        static IApiService ApiService = new ConsoleApiService();
        static IWriteService WriteService;

        static void Main(string[] args)
        {
            string outputType = ConfigurationManager.AppSettings["OutputType"];

            // determines how the program "writes" based on app.config value
            switch(outputType)
            {
                case "Console":
                    WriteService = new ConsoleWriteService();
                    break;
                case "Database":
                    WriteService = new DatabaseWriteService();
                    break;
                case "MessageBox":
                    WriteService = new MessageBoxWriteService();
                    break;
                default:
                    WriteService = new ConsoleWriteService();
                    break;
            }


            ApiService.WriteHelloWorld(WriteService);
            Console.WriteLine("\nPress Any Key to Exit");
            Console.ReadLine();
        }
    }
}
