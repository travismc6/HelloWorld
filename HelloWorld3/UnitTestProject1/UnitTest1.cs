using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld3;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WriteHelloWorldConsole()
        {
                IWriteService writeService = new ConsoleWriteService();
                ConsoleApiService apiService = new ConsoleApiService();

                Assert.AreEqual("Hello World", apiService.WriteHelloWorld(writeService) );
    
        }

        public void WriteHelloWorldDatabase()
        {
            IWriteService writeService = new ConsoleWriteService();
            ConsoleApiService apiService = new ConsoleApiService();

            apiService.WriteHelloWorld(writeService);

            // openDb, assert that last now 

            Assert.AreEqual("Hello World", helloWorldDb);
        }
    }
}
