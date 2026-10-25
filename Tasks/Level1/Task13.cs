using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task13
    {
        public void Run()
        {
            Console.WriteLine("=== Счётчик вхождений слов в тексте ===");
            string text = "C# — это отличный язык программирования. C# очень популярен, и изучать C# интересно и полезно!";

            Console.WriteLine($"Исходный текст:\n\"{text}\"\n");
            Dictionary<string, int> wordCounts = CountWords(text);

            Console.WriteLine("Результат (слово → количество, по убыванию):");
            // Сортируем словарь по значению (количеству) по убыванию с помощью LINQ
            foreach (var pair in wordCounts.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} → {pair.Value}");
            }
        }
        private Dictionary<string, int> CountWords(string input)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            if (string.IsNullOrWhiteSpace(input))
            {
                return counts;
            }
            input = input.ToLower();
            char[] separators = new char[] { ' ', ',', '.', '!', '?', '—', '-', ':', ';', '(', ')', '"', '\n', '\r', '\t' };
            string[] rawWords = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in rawWords)
            {
                
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                     
                    counts[word] = 1;
                }
            }

            return counts;
        }
    }
}
