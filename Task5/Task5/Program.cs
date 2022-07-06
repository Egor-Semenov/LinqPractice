using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = GetSortedWords("Next weekend i am going to Kayaking");

            list.ForEach(word => Console.WriteLine($"{word}"));
        }

        //<summary>
        //Дан текст, нужно составить список всех встречающихся в тексте слов,
        //упорядоченный сначала по возрастанию длины слова, а потом лексикографически.
        //Запрещено использовать ThenBy и ThenByDescending.
        //</summary>
        static List<string> GetSortedWords(string text)
        {
            return Regex.Split(text, @"\W+")
                .Select(word => word.ToLower())
                .Where(word => !string.IsNullOrEmpty(word))
                .Distinct()
                .OrderBy(word => Tuple.Create(word.Length, word))
                .ToList();
        }
    }
}
