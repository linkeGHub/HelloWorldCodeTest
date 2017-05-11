using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace API.Output.Outputters
{
    class DbOutput :Outputter
    {
        public override void Output(string input)
        {
            Result = "DbOutput:" + input;
            Console.WriteLine(Result);
        }
    }
}
