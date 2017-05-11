using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace API.Output.Outputters
{
    class MobileOutput : Outputter
    {
        public override void Output(string input)
        {
            Result = "MobileOutput:" + input;
            Console.WriteLine(Result);
        }

    }
}
