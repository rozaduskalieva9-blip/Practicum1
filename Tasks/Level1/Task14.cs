using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Tasks.Level1
{
    internal class Task14
    {
        public void Run()
        {
            Console.WriteLine("=== Расчёт точного возраста ===");

            Console.Write("Введите дату рождения (в формате ДД.ММ.ГГГГ, например, 15.05.2000): ");
            string input = Console.ReadLine();
            if (!DateTime.TryParse(input, out DateTime birthDate))
            {
                Console.WriteLine("Ошибка: некорректный формат даты! Пожалуйста, используйте формат ДД.ММ.ГГГГ.");
                return;
            }

            DateTime today = DateTime.Today;
            if (birthDate > today)
            {
                Console.WriteLine("Ошибка: дата рождения не может быть в будущем!");
                return;
            }

            CalculateAge(birthDate, today, out int years, out int months, out int days);

            Console.WriteLine($"\nРезультат: {years} лет, {months} месяцев, {days} дней");
        }
        private void CalculateAge(DateTime birthDate, DateTime currentDate, out int years, out int months, out int days)
        {
            years = currentDate.Year - birthDate.Year;
            months = currentDate.Month - birthDate.Month;
            days = currentDate.Day - birthDate.Day;
            if (days < 0)
            {
                months--;
                int previousMonth = currentDate.Month == 1 ? 12 : currentDate.Month - 1;
                int yearOfPreviousMonth = previousMonth == 12 ? currentDate.Year - 1 : currentDate.Year;
                days += DateTime.DaysInMonth(yearOfPreviousMonth, previousMonth);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
        }
    }
}


