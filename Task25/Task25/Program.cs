using System;
using System.Collections.Generic;
using System.Linq;

namespace Task25
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
                new Client {Id = 2, Year = 2015, Month = 12, OverallTrainingTime = 37 },
                new Client {Id = 2, Year = 2019, Month = 18, OverallTrainingTime = 48 },
                new Client {Id = 1, Year = 2015, Month = 7, OverallTrainingTime = 33 },
                new Client {Id = 3, Year = 2019, Month = 6, OverallTrainingTime = 36 },
                new Client {Id = 2, Year = 2017, Month = 12, OverallTrainingTime = 30 },
                new Client {Id = 5, Year = 2018, Month = 1, OverallTrainingTime = 40}
            };

            var infoList = FindClientMonthsCountEachYear(clients, 2);

            foreach(var info in infoList)
            {
                Console.WriteLine(info);
            }
        }

        //<summary>
        //Исходная последовательность содержит сведения о клиентах фитнес-центра.
        //Каждый элемент последовательности включает следующие целочисленные поля:
        //<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий(в часах)>;
        //Для каждого года, в котором клиент с кодом K посещал центр,
        //определить число месяцев, для которых продолжительность занятий
        //данного клиента превосходила 15 часов(вначале выводить число
        //месяцев, затем год). Сведения о каждом годе выводить на новой строке; данные упорядочивать по убыванию числа
        //месяцев, а при равном числе месяцев – по возрастанию номера года.
        //Если данные об указанном клиенте отсутствуют, то записать в результирующий файл строку «No data». 
        //</summary>
        static List<string> FindClientMonthsCountEachYear(List<Client> clients, int clientId)
        {
            var infoList = (from client in clients
                           where client.Id == clientId && client.OverallTrainingTime > 15
                           group client by client.Year into yearGroup
                           orderby yearGroup.Count() descending, yearGroup.Key
                           select $"Count: {yearGroup.Count()} - Year: {yearGroup.Key}").DefaultIfEmpty("No data").ToList();
                          
            return infoList;
        }
    }
}