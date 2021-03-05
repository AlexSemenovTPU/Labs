﻿using System;
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
            personListTwo.Add(personListOne.SearchByIndex(2));

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
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList());
        }

        /// <summary>
        /// Введение персоны с клавиатуры
        /// </summary>
        /// <returns>Экземпляр введенной с кдавиатуры персоны</returns>
        static public Person insertPerson(string name, string surname, uint age, string genderKey)
        {
            Gender gender = Gender.Male;

            if (genderKey == "Male")
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }

            return new Person(name, surname, age, gender);
        }

        private Person CheckPerson()
        {
            string name = "";
            string surname = "";
            uint uintage = 0;
            Gender gender;
            while (true)
            {
                try
                {
                    name = "Рома";
                    Person.CorrectName(name);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    surname = "Логинов";
                    Person.CorrectName(surname);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    string age = "30";
                    uintage = Convert.ToUInt32(age);
                    Person.CorrectAge(uintage);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                string gender = "Male";
                if (!Enum.IsDefined(typeof(Gender), gender))
                {
                    Console.WriteLine("Некорректно введён пол.\n");
                }
                else
                {
                    break;
                }
            }
            return new Person(name, surname, uintage, gender);
        }
    }
}
