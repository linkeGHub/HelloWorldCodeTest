using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using API.Output.Outputters;


namespace HelloWorldCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputterClass = ConfigurationSettings.AppSettings.Get("Outputter");
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output("Hello World");

            Console.ReadLine();
        }
    }
}
