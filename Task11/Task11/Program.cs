using System;
using System.Collections.Generic;
using System.Linq;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
            {
                new Client(1, 12, 1.5),
                new Client(3, 05, 2.5),
                new Client(2, 1, 1),
                new Client(4, 7, 1.5)
            };

            var client = FindMinTime(clients);

            Console.WriteLine($"Id: {client.id} - Month: {client.month} - Work time: {client.workTime}");
            
        }

        //<summary>
        //Исходная последовательность содержит сведения о клиентах фитнес-центра.
        //Найти элемент последовательности с минимальной продолжительностью занятий.
        //</summary>
        static Client FindMinTime(List<Client> clients)
        {
            var minTimeClient = (from client in clients
                                 select client).Min();

            return minTimeClient;
        }
    }
}

class Client : IComparable<Client>
{
    public int id;
    public int month;
    public double workTime;

    public Client(int id, int month, double workTime)
    {
        this.id = id;
        this.month = month;
        this.workTime = workTime;
    }

    public int CompareTo(Client other)
    { 
        return workTime.CompareTo(other.workTime); 
    }
}
