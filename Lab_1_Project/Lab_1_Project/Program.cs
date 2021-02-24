using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Program
    {
        static void Main(string[] args)
        {

            PersonList personListOne = new PersonList();
            PersonList personListTwo = new PersonList();

            Console.WriteLine("Создание двух списков персон по 3 человека в каждом:");
            for (int i = 0; i < 3; i++)
            {
                personListOne.Add(Randomizer.randomPerson());
                personListTwo.Add(Randomizer.randomPerson());
            }

            Console.ReadLine();

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

            Console.WriteLine("Добавление нового человека в первый список:");
            personListOne.Add(Randomizer.randomPerson());

            Console.ReadLine();

            Console.WriteLine("Копирование второго человека из первого списка в конец второго:");
            personListTwo.Add(personListOne.SearchByIdnex(2));

            ToConsole(personListOne, personListTwo);
            
            Console.ReadLine();

            Console.WriteLine("Удаление второго человека из первого списка:");
            personListOne.ElementDelete(2);

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

            Console.WriteLine("Очистка второго списка:");
            personListTwo.DeleteAll();
                        
            Console.ReadLine();

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

        }

        /// <summary>
        /// Вывод списков персон в консоль
        /// </summary>
        static void ToConsole(PersonList personListOne, PersonList personListTwo)
        {
            string personInfo = "";

            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList(personInfo));
        }

        /// <summary>
        /// Введение персоны с клавиатуры
        /// </summary>
        /// <returns>Экземпляр введенной с кдавиатуры персоны</returns>
        static public Person insertPerson(string name, string surname, uint age, string genderInsert)
        {
            Gender gender = Gender.Male;

            if (genderInsert == "Male")
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }

            return new Person(name, surname, age, gender);
        }
    }
}
