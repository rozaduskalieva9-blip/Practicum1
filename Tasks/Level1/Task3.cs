using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task3
    {
        public void Run()
        {
            Console.WriteLine("=== Калькулятор ===");

          
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ошибка: некорректный формат первого числа!");
                return;
            }

           
            Console.Write("Введите оператор (+, -, *, /): ");
            string op = Console.ReadLine();
             
            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ошибка: некорректный формат второго числа!");
                return;
            }

            double result = 0;
            bool isValid = true;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                  
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        isValid = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    isValid = false;
                    break;
            }
            if (isValid)
            {
                Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
            }
        }
    }
}
    
