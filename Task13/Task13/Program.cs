using System;
using System.Linq;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultArray = FindCollection(new[] { 1, 3, 4, -2, 14, -78, 73, -5, 11, 2, 3 }, 6);

            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
        }

        //<summary>
        //Даны целое число и целочисленная последовательность. Начиная с первого элемента последовательности,
        //большего заданного числа, извлечь из
        //последовательности все нечетные положительные числа, поменяв порядок извлеченных чисел на обратный.
        //<summary>
        static int[] FindCollection(int[] array, int number)
        {
            var resultArray = (from element in array
                       where element % 2 != 0 && element > 0
                       select element).SkipWhile(element => element < number).Reverse().ToArray();

            return resultArray;
        }
    }
}
