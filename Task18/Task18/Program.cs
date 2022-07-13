using System;
using System.Collections.Generic;
using System.Linq;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = CreateNewList(new List<int> { 1, 15, 42, 3, 26, 4 }, new List<int> { 15, 4, 12, 3, 0, 14 }, 5, 7);

            foreach (var item in newList)
            {
                Console.Write($"{item} ");
            }
        }

        //<summary>
        //Даны целые числа K1 и K2 и целочисленные последовательности A и B.
        //Получить последовательность, содержащую все числа из A, большие K1, и все числа из B, меньшие K2.
        //Отсортировать полученную последовательность по возрастанию.
        //</summary>
        static List<int> CreateNewList(List<int> firstDataList, List<int> secondDataList, int firstComparasingNumber, int secondComparasingNumber)
        {
            var newList = firstDataList.Where(number => number > firstComparasingNumber)
                .Concat(secondDataList.Where(element => element < secondComparasingNumber))
                .OrderBy(element => element)
                .ToList();

            return newList;
        }
    }
}
