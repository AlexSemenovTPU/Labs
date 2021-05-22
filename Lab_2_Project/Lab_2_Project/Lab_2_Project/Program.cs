using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_Project
{
    //TODO: RSDN+
    /// <summary>
    /// Класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Console.WriteLine("Наажмите клавишу...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Генерация 7 случайных людей...");
            Console.WriteLine();
            Console.ReadKey();

            var listOfPersons = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                listOfPersons.Add(Randomizer.CreateRandomPerson());
            }

            Console.WriteLine();
            Console.WriteLine("Randomly generated list:\n");


            Console.WriteLine(listOfPersons.ShowList());
            Console.ReadKey();

            Console.WriteLine("Определение типа четвёртого человека в списке...");
            Console.ReadKey();

            switch (listOfPersons.SearchByIndex(3))
            {
                case Adult adult:
                    {
                        Console.WriteLine("Тип четвёртого человека в списке - Adult");
                        Console.WriteLine(adult.Checkob("Шаурма у Нурика"));
                        break;
                    }
                case Child child:
                    {
                        Console.WriteLine("Тип четвёртого человека в списке - Child");
                        Console.WriteLine(child.CheckInterest());
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
