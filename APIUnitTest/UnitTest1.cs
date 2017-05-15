using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Output;

namespace APIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConsoleOutput()
        {
            var outputterClass = "API.Output.Outputters.ConsoleOutput";
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output("Hello World");

            Assert.AreEqual("ConsoleOutput:Hello World", outputterObj.Result);
        }
        [TestMethod]
        public void TestDbOutput()
        {
            var outputterClass = "API.Output.Outputters.DbOutput";
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output("Hello World");

            Assert.AreEqual("DbOutput:Hello World", outputterObj.Result);
        }
    }
}
