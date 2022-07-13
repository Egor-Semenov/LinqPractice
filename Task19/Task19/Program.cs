using System;
using System.Collections.Generic;
using System.Linq;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultList = ConcatLists(new List<int> { 2, 13, 25, 15, 5, 14, 23 }, new List<int> { 12, 18, 35, 6, 95, 17, 3 });

            foreach (var pair in resultList)
            {
                Console.WriteLine(pair);
            }
        }

        //<summary>
        //Даны последовательности положительных целых чисел A и B;
        //все числа в каждой последовательности различны.
        //Найти последовательность всех пар чисел, удовлетворяющих следующим условиям:
        //первый элемент пары принадлежит последовательности A,
        //второй принадлежит B, и оба элемента оканчиваются одной и той же цифрой.
        //</summary
        static List<string> ConcatLists(List<int> firtsList, List<int> secondList)
        {
            var resultList = firtsList
                .SelectMany(firstElement =>
                secondList.Where(secondElement => firstElement % 10 == secondElement % 10)
                .Select(secondElement => $"{firstElement} - {secondElement}"))
                .ToList();

            return resultList;
        }
    }
}
