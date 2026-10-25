using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task4
    {
        public void Run()
        {
            Console.WriteLine("=== Проверка чётности числа ===");

            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: введено не целое число!");
                return;
            }
            bool isEvenMethod1 = CheckEvenModulo(number);
            string isEvenMethod2 = CheckEvenTernary(number);

            Console.WriteLine("\nРезультаты проверки:");
            Console.WriteLine($"Способ 1 (% 2 == 0): Число чётное? -> {isEvenMethod1}");
            Console.WriteLine($"Способ 2 (тернарный оператор): -> {isEvenMethod2}");
        }
         
        private bool CheckEvenModulo(int n)
        {
            return n % 2 == 0;
        }
 
        private string CheckEvenTernary(int n)
        {
            return (n % 2 == 0) ? "Чётное" : "Нечётное";
        }
    }
}
    