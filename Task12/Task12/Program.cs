using System;
using System.Linq;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var resArray = FindUniqueOdd(new[] { 1, 13, 14, 89, 12, 14, 13, 15, 15, 16, 3, 2 });

            foreach (var item in resArray)
            {
                Console.WriteLine(item);
            }
        }

        //<summary>
        //Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
        //сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.
        //</summary>
        static int[] FindUniqueOdd(int[] array)
        {
            var result = (from element in array
                          where element % 2 != 0
                          select element).Distinct().ToArray();
    
            return result;
        }
    }
}
