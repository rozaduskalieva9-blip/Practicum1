using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task10
    {
        public void Run()
        {
            Console.WriteLine("=== Сравнение сортировок: Пузырек vs Вставки ===");

            int size = 10000;
            int[] originalArray = GenerateRandomArray(size, 1, 100000);
            int[] arrayBubble = (int[])originalArray.Clone();
            int[] arrayInsertion = (int[])originalArray.Clone();
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(arrayBubble);
            stopwatch.Stop();
            long timeBubble = stopwatch.ElapsedMilliseconds;
            stopwatch.Restart();
            InsertionSort(arrayInsertion);
            stopwatch.Stop();
            long timeInsertion = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Размер массива: {size} элементов\n");
            Console.WriteLine($"Время BubbleSort (пузырек): {timeBubble} мс");
            Console.WriteLine($"Время InsertionSort (вставки): {timeInsertion} мс");
            bool areEqual = AreArraysEqual(arrayBubble, arrayInsertion);
            Console.WriteLine($"\nРезультаты сортировок идентичны: {areEqual}");
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

        
        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                       
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                
                if (!swapped) break;
            }
        }

        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        
        private bool AreArraysEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}
