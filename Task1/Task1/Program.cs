using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);

            foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
        }

        //<summary>
        //Вернуть массив чисел из массива строк
        //</summary>
        static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines
                .Where(line => line.Length > 0)
                .Select(line => int.Parse(line))
                .ToArray();
        }
    }
}
