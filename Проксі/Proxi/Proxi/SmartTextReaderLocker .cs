using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private Regex regex;

        public SmartTextReaderLocker(string file, string reg) : base(file)
        {
            regex = new Regex(reg);
        }

        public char[][] ReadFile()
        {
            if (regex.IsMatch(file))
            {
                Console.WriteLine("Доступ заборонено!");
                return new char[0][];
            }
            else
            {
                Console.WriteLine("Доступ дозволено!");
                return base.ReadFile();
            }
        }
    }
}
