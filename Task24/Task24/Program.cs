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
                new Client {Id = 4, Year = 2016, Month = 1, OverallTrainingTime = 30 },
                new Client {Id = 1, Year = 2018, Month = 12, OverallTrainingTime = 50 },
                new Client {Id = 3, Year = 2015, Month = 12, OverallTrainingTime = 37 },
                new Client {Id = 2, Year = 2019, Month = 18, OverallTrainingTime = 48 },
                new Client {Id = 1, Year = 2015, Month = 7, OverallTrainingTime = 33 },
                new Client {Id = 3, Year = 2019, Month = 6, OverallTrainingTime = 36 },
                new Client {Id = 4, Year = 2017, Month = 12, OverallTrainingTime = 30 },
                new Client {Id = 5, Year = 2018, Month = 1, OverallTrainingTime = 40}
            };

            var clientsInfo = FindClientMonthCount(clients);

            foreach (var clientInfo in clientsInfo)
            {
                Console.WriteLine(clientInfo);
            }
        }

        //<summary>
        //Исходная последовательность содержит сведения о клиентах фитнес-центра.
        //Каждый элемент последовательности включает следующие целочисленные поля:
        //<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий (в часах)>;
        //Для каждого клиента, присутствующего в исходных данных,
        //определить общее количество месяцев, в течение которых он посещал занятия(вначале выводить количество месяцев, затем код
        //клиента). Сведения о каждом клиенте выводить на новой строке и
        //упорядочивать по возрастанию количества месяцев, а при их равенстве – по возрастанию кода клиента.
        //</summary>
        static List<string> FindClientMonthCount(List<Client> clients)
        {
            var clientsInfo = (from client in clients
                         group client by client.Id into clientGroup
                         orderby clientGroup.Count(), clientGroup.Key
                         select $"Count of month: {clientGroup.Count()} - Id: {clientGroup.Key}").ToList();

            return clientsInfo;
        }
    }
}