using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLongest(new[] { "azaz", "as", "sdsd" }));
            Console.WriteLine(GetLongest(new[] { "zzzz", "as", "sdsd" }));
            Console.WriteLine(GetLongest(new[] { "as", "12345", "as", "sds" }));
        }

        //<summary>
        //Дан список слов, нужно найти самое длинное слово из этого списка,
        //а из всех самых длинных — лексикографически первое слово.
        //</summary>
        static string GetLongest(IEnumerable<string> words)
        {
            return words
                .Select(word => Tuple.Create(word.Length, word))
                .Where(tuple => tuple.Item1 == words.Max(word => word.Length))
                .Min(tuple => tuple.Item2);
        }
    }
}
