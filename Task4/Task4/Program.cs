using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var vocabulary = GetSortedWords
                (
                "Hello, hello, hello, how low",
                "",
                "With the lights out, it's less dangerous",
                "Here we are now; entertain us",
                "I feel stupid and contagious",
                "Here we are now; entertain us",
                "A mulatto, an albino, a mosquito, my libido...",
                "Yeah, hey"
                );

            foreach (var word in vocabulary)
            {
                Console.WriteLine(word);
            }
        }

        //<summary>
        //Текст задан массивом строк.
        //Вам нужно составить лексикографически упорядоченный список всех встречающихся в этом тексте слов.
        //Слова нужно сравнивать регистронезависимо, а выводить в нижнем регистре.
        //</summary>
        static string[] GetSortedWords(params string[] textLines)
        {
            return textLines
                .SelectMany(line => Regex.Split(line, @"\W+"))
                .Select(word => word.ToLower())
                .OrderBy(word => word)
                .Distinct()
                .ToArray();
        }
    }
}
