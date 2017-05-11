using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace API.Output.Outputters
{
    public class OutputterFactory
    {
        public static Outputter GetOutputter(string outputter)
        {
            //var outputter = ConfigurationSettings.AppSettings.Get("Outputter");
            var op = Activator.CreateInstance("API.Output", outputter);

            //var op1 = new ConsoleOutput();
            return op.Unwrap() as Outputter;
        }
    }
}
