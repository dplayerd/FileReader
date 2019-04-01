using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moudou.FileReader.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLineReader reader = new FileLineReader();

            var enm = reader.ReadEachLine("D:\\Logs\\ue190315.log");

            foreach (string[] columns in enm)
            {

            }
        }
    }
}
