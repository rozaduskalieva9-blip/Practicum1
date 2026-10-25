using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task11
    {
        public void Run()
        {
            Console.WriteLine("=== Сумма главной диагонали матрицы N×N ===");

            int n = 0;
            // Запрашиваем размер матрицы с проверкой (минимум 2)
            while (true)
            {
                Console.Write("Введите размер матрицы N (минимум 2): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2)
                {
                    break;
                }
                Console.WriteLine("Ошибка: введите целое число, большее или равное 2.");
            }

            int[,] matrix = new int[n, n];
            Random rand = new Random();
            int diagonalSum = 0;

            Console.WriteLine($"\nСгенерированная матрица {n}×{n}:");

            // Заполняем матрицу, выводим её на экран и сразу считаем диагональ
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Заполняем числами от 1 до 9 для компактности и наглядности в консоли
                    matrix[i, j] = rand.Next(1, 10);
                    Console.Write($"{matrix[i, j],4}");
                }

                // Элементы главной диагонали находятся там, где номер строки равен номеру столбца (i == j)
                diagonalSum += matrix[i, i];
                Console.WriteLine(); // Переход на новую строку матрицы
            }

            Console.WriteLine($"\nСумма элементов главной диагонали: {diagonalSum}");
        }
    }
}
