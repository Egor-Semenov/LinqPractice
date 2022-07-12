using System;
using System.Collections;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Tom", "Microsoft"), 
                new Person("Sam", "Google"),
                new Person("Bob", "JetBrains"), 
                new Person("Mike", "Microsoft"),
            };

            Company[] companies =
            {
                new Company("Microsoft", "C#"),
                new Company("Google", "Go"),
                new Company("Oracle", "Java")
            };

            //<summary>
            //Соединить по общему критерию два набора классов
            //</summary>

            var employees = from person in people
                            join company in companies on person.company equals company.title
                            select new { Name = person.name, Company = company.title, Language = company.language };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Company} - {employee.Language}");
            }
        }
    }
}

class Person
{
    public string name;
    public string company;

    public Person(string name, string company)
    {
        this.name = name;
        this.company = company;
    }
}

class Company
{
    public string title;
    public string language;

    public Company(string title, string language)
    {
        this.title = title;
        this.language = language;
    }
}
