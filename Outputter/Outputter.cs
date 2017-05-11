using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Output
{
    public abstract class Outputter
    {
        public string Result { get; protected set; }
        public abstract void Output(string input);
    }
}
