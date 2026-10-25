using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task5
    {
        public void Run()
        {
            Console.WriteLine("=== Таблица умножения 10×10 ===\n");
            Console.Write("     "); 
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,4}"); 
            }
            Console.WriteLine();
            Console.WriteLine("    " + new string('-', 45));  
            for (int row = 1; row <= 10; row++)
            {
                Console.Write($"{row,2} | ");

                for (int col = 1; col <= 10; col++)
                {
                    int result = row * col;
                    
                    Console.Write($"{result,4}");
                }
                Console.WriteLine(); // Переход на новую строку после завершения ряда
            }
        }
    }
}
    