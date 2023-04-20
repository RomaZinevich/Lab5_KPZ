using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextChecker : SmartTextReader
    {
        public SmartTextChecker(string file) : base(file) { }

        public new char[][] ReadFile()
        {
            Console.WriteLine($"============================");
            Console.WriteLine($"Вiдкрив файл: {file}");
            char[][] chars = base.ReadFile();
            Console.WriteLine($"Закрiнчив зчитувати файл: {file}");
            Console.WriteLine($"Закрив файл: {file}");
            Console.WriteLine($"Кiлькiсть рядкiв: {chars.Length}");
            Console.WriteLine($"Кiлькiсть символiв: {GetTotalCharCount(chars)}");
            Console.WriteLine($"============================");
            return chars;
        }

        private int GetTotalCharCount(char[][] chars)
        {
            int count = 0;
            foreach (char[] line in chars)
            {
                count += line.Length;
            }
            return count;
        }
    }
}
