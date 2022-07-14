using System;
using System.Collections.Generic;
using System.Linq;

namespace Task24
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

            var yearTimes = FindTraineTimeInYear(clients);

            foreach (var time in yearTimes)
            {
                Console.WriteLine(time);
            }
        }

        //<summary>
        //Исходная последовательность содержит сведения о клиентах фитнес-центра.
        //Каждый элемент последовательности включает следующие целочисленные поля:
        //<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий (в часах)>;
        //Вывести суммарную продожительность занятий за год, отсортированню по возрастанию.
        //При наличии одинаковых от меньшего к большему году
        //</summary>
        static List<string> FindTraineTimeInYear(List<Client> clients)
        {
            var years = (from client in clients
                         group client by client.Year into yearGroup
                         orderby yearGroup.Sum(client => client.OverallTrainingTime), yearGroup.Key
                         select $"{yearGroup.Key} - {yearGroup.Sum(client => client.OverallTrainingTime)}").ToList();

            return years;
        }
    }
}