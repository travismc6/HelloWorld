using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static IApiService ApiService = new ConsoleApiService();

        static void Main(string[] args)
        {
            ApiService.WriteHelloWorld();
            Console.ReadLine();
        }
    }
}
