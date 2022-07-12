using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int>[] result = GetMostFrequentWords("A box of biscuits, a box of mixed biscuits, and a biscuit mixer.", 2);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1} - {item.Item2}");
            }
        }

        //<summary>
        //Дан текст, нужно вывести заданное количество наиболее часто встречающихся в тексте слов вместе с их частотой.
        //Среди слов, встречающихся одинаково часто, отдавать предпочтение лексикографически меньшим словам.
        //Слова сравнивать регистронезависимо и выводить в нижнем регистре.
        static Tuple<string, int>[] GetMostFrequentWords(string text, int count)
        {
            return Regex.Split(text, @"\W+")
                .Where(word => !string.IsNullOrEmpty(word))
                .GroupBy(word => word.ToLower())
                .OrderByDescending(group => group.Count())
                .ThenBy(group => group.Key)
                .Select(group => Tuple.Create(group.Key, group.Count()))
                .Take(count)
                .ToArray();
        }
    }
}
