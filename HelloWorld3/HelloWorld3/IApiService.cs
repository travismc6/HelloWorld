using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    interface IApiService
    {
        string WriteHelloWorld(IWriteService writeService);
    }

    public class ConsoleApiService : IApiService
    {
        public string WriteHelloWorld(IWriteService writeService)
        {
            return writeService.Write("Hello World");
           
        }
    }
}
