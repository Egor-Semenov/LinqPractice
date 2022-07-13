using System;
using System.Collections.Generic;
using System.Linq;

namespace Task21
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
                new Client {Id = 3, Year = 2019, Month = 10, OverallTrainingTime = 36 },
                new Client {Id = 4, Year = 2017, Month = 12, OverallTrainingTime = 30 },
                new Client {Id = 5, Year = 2018, Month = 1, OverallTrainingTime = 40}
            };

            var sameTimeClients = FindSameTimeClients(clients);

            foreach (var time in sameTimeClients)
            {
                Console.WriteLine(time);
            }
        }

        //<summary>
        //Для каждой пары «год–месяц», присутствующей в исходных
        //данных, определить количество клиентов, которые посещали центр
        //в указанное время(вначале выводится год, затем месяц, потом количество клиентов). Сведения о каждой паре «год–месяц» выводить
        //на новой строке и упорядочивать по убыванию номера года, а для
        //одинакового номера года – по возрастанию номера месяца.
        //</summary>
        static List<string> FindSameTimeClients(List<Client> clients)
        {
            var sameTime = clients
                .GroupBy(client => (client.Year, client.Month))
                .OrderByDescending(client => client.Key.Year)
                .ThenBy(client => client.Key.Month)
                .Select(client => $"{client.Key} {client.Count()}").ToList();
                        
            return sameTime;
        }
    }
}