using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task6
    {
        public void Run()
        {
            Console.WriteLine("=== Сумма цифр числа ===");

            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: введено не целое число!");
                return;
            }
            int sumString = SumDigitsString(number);
            int sumMath = SumDigitsMath(number);

            Console.WriteLine("\nРезультаты:");
            Console.WriteLine($"Способ 1 (через строку): сумма цифр = {sumString}");
            Console.WriteLine($"Способ 2 (через арифметику): сумма цифр = {sumMath}");
        }
        private int SumDigitsString(int n)
        {
            n = Math.Abs(n);
            string s = n.ToString();
            int sum = 0;

            foreach (char c in s)
            {
                sum += int.Parse(c.ToString());
            }

            return sum;
        }
        private int SumDigitsMath(int n)
        {            
            n = Math.Abs(n);
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;  
                n /= 10;        
            }
            return sum;
        }
    }
}
    