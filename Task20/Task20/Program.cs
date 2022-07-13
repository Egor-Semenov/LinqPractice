using System;
using System.Collections.Generic;
using System.Linq;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumList = FindSums(new List<int> { 1, 12, 25, 3, 0 }, new List<int> { 24, 12, 3, 14, 5, 25 });

            foreach (var sum in sumList)
            {
                Console.Write($"{sum} ");
            }
        }

        //<summary>
        //Даны целочисленные последовательности A и B.
        //Получить последовательность всех различных сумм,
        //в которых первое слагаемое берется из A, а второе из B.
        //Упорядочить полученную последовательность по возрастанию.
        //</summary>
        static List<int> FindSums(List<int> firstList, List<int> secondList)
        {
            var resultList = firstList
                .SelectMany(firstElement =>
                secondList.Select(secondElement => firstElement + secondElement))
                .Distinct()
                .OrderBy(sum => sum)
                .ToList();

            return resultList;
        }
    }
}
