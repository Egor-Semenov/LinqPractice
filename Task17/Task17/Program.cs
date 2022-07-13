using System;
using System.Collections.Generic;
using System.Linq;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = CreateNewList(new List<int> { 1, 12, 14, 3, 56, 8, 4, 75 });

            foreach (var item in newList)
            {
                Console.Write($"{item} ");
            }
        }

        //<summary>
        //Дана целочисленная последовательность A.
        //Получить новую последовательность чисел,
        //элементы которой определяются по соответствующим элементам последовательности A следующим образом:
        //если порядковый номер элемента A делится на 3 (3, 6, …),
        //то этот элемент в новую последовательность не включается;
        //если остаток от деления порядкового номера на 3 равен 1 (1, 4, …),
        //то в новую последовательность добавляется удвоенное значение этого элемента;
        //в противном случае (для элементов A с номерами 2, 5, …) элемент добавляется в новую последовательность без изменений.
        //В полученной последовательности сохранить исходный порядок следования элементов.
        //</summary>
        static List<int> CreateNewList(List<int> dataToCreate)
        {
            var newList = (from number in dataToCreate
                           where number % 3 != 0
                           select number % 3 == 1 ? number * 2 : number).ToList();

            return newList;
        }
    }
}
