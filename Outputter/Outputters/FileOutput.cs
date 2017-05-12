using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace API.Output.Outputters
{
    class FileOutput: Outputter
    {
        public override void Output(string input)
        {
            string fn = @"c:\tmp\output.txt";
            FileInfo fi = new FileInfo(fn);
             
            if (!fi.Directory.Exists) fi.Directory.Create();

            var fs = fi.OpenWrite();
            var bytes = Encoding.ASCII.GetBytes(input);
            fs.Write(bytes,0,bytes.Length);
            fs.Close();
          
        }
    }
}
