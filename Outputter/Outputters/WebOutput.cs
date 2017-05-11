using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Output.Outputters
{
    class WebOutput : Outputter
    {
        public override void Output(string input)
        {
            Result = "WebOutput:" + input;
            Console.WriteLine(Result);
        }
    }
}
