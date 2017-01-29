using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    // API to support mobile applications, console applications, services, ect.
    public interface IApiService
    {
        void WriteHelloWorld();
    }

    // Concrete class for implementing api's for console
    public class ConsoleApiService : IApiService
    {
        public void WriteHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
