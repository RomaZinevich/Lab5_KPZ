using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextReader
    {
        protected string file;

        public SmartTextReader(string file)
        {
            this.file = file;
        }

        public char[][] ReadFile()
        {
            string[] lines = File.ReadAllLines(file);
            char[][] chars = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                chars[i] = lines[i].ToCharArray();
            }

            return chars;
        }
    }
}
