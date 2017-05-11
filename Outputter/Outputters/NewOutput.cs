using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Output.Outputters
{
    class NewOutput : Outputter
    {
        public override void Output(string input)
        {
            Result = "NewOutput:"+input;
            Console.WriteLine(Result);
        }
    }
}
