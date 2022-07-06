using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom[] classes =
            {
                new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
                new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
                new Classroom {Students = {"Bulat", "Alex", "Galina"},}
            };

            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }

        //<summary>
        //Вам дан список всех классов в школе.
        //Нужно получить список всех учащихся всех классов.
        //</summary>
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes
                .SelectMany(classRoom => classRoom.Students)
                .ToArray();
        }
    }
}
