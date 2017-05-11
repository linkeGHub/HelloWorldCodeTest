using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Output.Outputters;

namespace APIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWebOutput()
        {
            var outputterClass = "API.Output.Outputters.WebOutput";
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output("Hello World");

            Assert.AreEqual("WebOutput:Hello World", outputterObj.Result);
        }
        [TestMethod]
        public void TestMobileOutput()
        {
            var outputterClass = "API.Output.Outputters.MobileOutput";
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output("Hello World");

            Assert.AreEqual("MobileOutput:Hello World", outputterObj.Result);
        }
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
