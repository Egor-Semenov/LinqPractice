using System;
using System.Linq;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = ReturnStrings(new[] { "Hello", "4455", "Google" }, new[] { "Ozon", "1444" });

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        //<summary>
        //Даны строковые последовательности A и B.
        //Строки последовательностей содержат только цифры и заглавные буквы латинского алфавита.
        //Получить последовательность, содержащую все строки из A
        //и все строки из B. Отсортировать полученную последовательность в лексикографическом порядке по убыванию.
        //</summary>

        static string[] ReturnStrings(string[] A, string[] B)
        {
            return A.Union(B)
                .Where(word => !int.TryParse(word, out int number))
                .OrderByDescending(word => word)
                .ToArray();
        }
    }
}
