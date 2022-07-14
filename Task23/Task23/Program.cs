using System;
using System.Collections.Generic;
using System.Linq;

namespace Task23
{
    class Client
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OverallTrainingTime { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
            {
                new Client {Id = 1, Year = 2019, Month = 10, OverallTrainingTime = 30 },
                new Client {Id = 2, Year = 2017, Month = 11, OverallTrainingTime = 36 },
                new Client {Id = 3, Year = 2019, Month = 11, OverallTrainingTime = 36 },
                new Client {Id = 4, Year = 2017, Month = 12, OverallTrainingTime = 30 },
                new Client {Id = 5, Year = 2018, Month = 1, OverallTrainingTime = 40}
            };

            var maxTraineTimeYear = FindMaxTraineTimeYear(clients);

            Console.WriteLine(maxTraineTimeYear);
        }

        //<summary>
        //Исходная последовательность содержит сведения о клиентах фитнес-центра.
        //Каждый элемент последовательности включает следующие целочисленные поля:
        //<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий (в часах)>;
        //Определить год, в котором суммарная продолжительность занятий всех клиентов была наибольшей,
        //и вывести этот год и наибольшую суммарную продолжительность. Если таких годов было
        //несколько, то вывести наименьший из них.
        //</summary>
        static string FindMaxTraineTimeYear(List<Client> clients)
        {
            var year = (from client in clients
                         group client by client.Year into yearGroup
                         orderby yearGroup.Sum(client => client.OverallTrainingTime) descending, yearGroup.Key
                         select $"{yearGroup.Key} - {yearGroup.Sum(client => client.OverallTrainingTime)}").First();

            return year;
        }
    }
}