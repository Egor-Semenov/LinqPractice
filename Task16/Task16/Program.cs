using System;
using System.Collections.Generic;
using System.Linq;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastDigits = FindLastNumbersDigit(new List<int> { -15, -31, 134, 16, 1, -34, 94, 199, 5, 19, -121, 10 });

            foreach (var digit in lastDigits)
            {
                Console.WriteLine(digit);
            }
        }

        //<summary>
        //Дана целочисленная последовательность.
        //Обрабатывая только положительные числа,
        //получить последовательность их последних цифр и
        //удалить в полученной последовательности все вхождения одинаковых цифр, кроме первого.
        //Порядок полученных цифр должен соответствовать порядку исходных чисел.
        //</summary>
        static List<int> FindLastNumbersDigit(List<int> data)
        {
            var lastDigits = (from number in data
                              where number > 0
                              select number % 10).Distinct().ToList();

            return lastDigits;
        }
    }
}
