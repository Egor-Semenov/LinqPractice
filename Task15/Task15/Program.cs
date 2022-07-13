using System;
using System.Collections.Generic;
using System.Linq;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> data = GetFirstCharacters(new List<string>() { "first", "last", "my", "game" });

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        //<summary>
        //Дана последовательность непустых строк A.
        //Получить последовательность символов,
        //каждый элемент которой является начальным символом соответствующей строки из A.
        //Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.
        //</summary>
        static List<char> GetFirstCharacters(List<string> stringList) 
        {
            var resultList = (from word in stringList
                              select word[0]).Reverse().ToList();

            return resultList;
        } 
    }
}
