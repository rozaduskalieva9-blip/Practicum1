using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task12
    {
        public void Run()
        {
            Console.WriteLine("=== Проверка строки на палиндром ===");

            Console.Write("Введите строку для проверки: ");
            string input = Console.ReadLine();

            // Защита на случай пустой строки от ReadLine
            if (input == null)
            {
                input = "";
            }

            bool isPalindrome = CheckPalindrome(input);

            Console.WriteLine($"\nРезультат: строка палиндром? -> {isPalindrome}");
        }

        // Метод проверки палиндрома
        private bool CheckPalindrome(string s)
        {
            // Пустая строка или строка из 1 символа — палиндром по условию
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return true;
            }

            // 1. Очищаем строку: удаляем пробелы, пунктуацию и приводим к нижнему регистру
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                // Оставляем только буквы и цифры, игнорируя пробелы и знаки препинания
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }

            string cleaned = sb.ToString();

            // Если после очистки строка пустая или из 1 символа — это тоже палиндром
            if (cleaned.Length <= 1)
            {
                return true;
            }

            // 2. Проверяем символы с двух концов с помощью двух указателей (left и right)
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    return false; // Нашли несовпадение — не палиндром
                }
                left++;
                right--;
            }

            return true; // Все символы совпали
        }
    }
}
