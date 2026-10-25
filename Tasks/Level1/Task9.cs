using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task9
    {
        public void Run()
        {
            Console.WriteLine("=== Статистика массива (min/max/sum/avg) ===");
            int[] numbers = GenerateRandomArray(20, 1, 100);

            Console.WriteLine("Сгенерированный массив:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            int min = GetMin(numbers);
            int max = GetMax(numbers);
            int sum = GetSum(numbers);
            double avg = GetAverage(numbers);
            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее арифметическое: {avg:F2}");
        }

    
        private int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }
            return array;
        }
        private int GetMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0; 

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        private int GetMax(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private int GetSum(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        private double GetAverage(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int sum = GetSum(arr);
            return (double)sum / arr.Length;
        }
    }
}
