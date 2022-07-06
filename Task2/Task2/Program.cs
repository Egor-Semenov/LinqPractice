using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);

            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);
        }

        public class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X, Y;
        }

        //<summary>
        //В каждой строке написаны две координаты точки (X, Y), разделенные пробелом.
        //Вернуть список точек
        //</summary>
        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            return lines
                .Select(line => line.Split(" "))
                .Select(array => array.Select(number => int.Parse(number)).ToArray())
                .Select(array => new Point(array[0], array[1]))
                .ToList();
        }
    }
}
