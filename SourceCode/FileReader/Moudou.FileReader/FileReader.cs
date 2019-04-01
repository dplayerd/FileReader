using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moudou.FileReader
{
    class FileReader
    {
        /// <summary> Read each line </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<string[]> ReadEachLine(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
            {
                string line = string.Empty;


                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    string[] record = line.Split(new char[] { ',', ' ' });

                    yield return record;
                }
            }
        }
    }
}
