using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace HelloWorld3UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConsoleWrite()
        {
            Class1 calss;

            ConsoleWriteService writeService = new IWriteService();
        }
    }
}
