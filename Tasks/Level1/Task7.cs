using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task7
    {
        public void Run()
        {
            Console.WriteLine("=== Реверс строки ===");

            Console.Write("Введите строку для реверса: ");
            string input = Console.ReadLine();
            if (input == null)
            {
                input = "";
            }
            string reversed = ReverseString(input);

            Console.WriteLine($"Результат: \"{reversed}\"");
        }

        private string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            char[] charArray = s.ToCharArray();
            char[] reversedArray = new char[charArray.Length];
            int j = 0;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversedArray[j] = charArray[i];
                j++;
            }
            return new string(reversedArray);
        }
    }
}
