using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string personInfo = "";

            PersonList personListOne = new PersonList();
            PersonList personListTwo = new PersonList();

            Console.WriteLine("Создание двух списков персон по 3 человека в каждом:");
            for (int i = 0; i < 3; i++)
            {
                personListOne.Add(Randomizer.randomPerson());
                personListTwo.Add(Randomizer.randomPerson());
            }

            Console.ReadLine();

            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList(personInfo));

            Console.ReadLine();

            Console.WriteLine("Добавление нового человека в первый список:");
            personListOne.Add(Randomizer.randomPerson());

            Console.ReadLine();

            Console.WriteLine("Копирование второго человека из первого списка в конец второго:");
            personListTwo.Add(personListOne.SearchByIdnex(2));

            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList(personInfo));

            Console.ReadLine();

            Console.WriteLine("Удаление второго человека из первого списка:");
            personListOne.ElementDelete(2);

            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList(personInfo));

            Console.ReadLine();

            Console.WriteLine("Очистка второго списка:");
            personListTwo.DeleteAll();
                        
            Console.ReadLine();

            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList(personInfo));

            Console.ReadLine();

        }
    }
}
