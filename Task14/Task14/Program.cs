using System;
using System.Linq;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = FindCollection(new[] { 15, 25, 11, 36, 55, 15, 25 }, 5);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        //<summary>
        //Даны цифра D (целое однозначное число) и целочисленная последовательность A.
        //Извлечь из A все различные положительные числа, оканчивающиеся цифрой D (в исходном порядке).
        //При наличии повторяющихся элементов удалять все их вхождения,
        //кроме последних.
        //</summary>
        static int[] FindCollection(int[] A, int D)
        {
            var resultArray = (from element in A
                               where element > 0 && element % 10 == D
                               select element).Reverse().Distinct().Reverse().ToArray();

            return resultArray;
        }
    }
}
