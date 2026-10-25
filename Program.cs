using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Practicum.Tasks.Level1.Task15();
            task.Run();

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
