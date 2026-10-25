using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task8
    {
        public void Run()
        {
            Console.WriteLine("=== Задача FizzBuzz (1–100) ===\n");
  
            for (int i = 1; i <= 100; i++)
            { 
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
               
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } 
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
