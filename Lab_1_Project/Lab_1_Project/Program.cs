﻿using System;
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
            PersonList personListOne = new PersonList();
            PersonList personListTwo = new PersonList();
            
            for (int i = 0; i < 3; i++)
            {
                personListOne.Add(Randomizer.randomPerson());
                personListTwo.Add(Randomizer.randomPerson());
            }
            string personInfo = "";
            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine(personListTwo.ShowList(personInfo));

            Console.WriteLine(personListOne.IndexSearch(1));

            Console.WriteLine(personListOne.ShowList(personInfo));
            Console.WriteLine(personListTwo.ShowList(personInfo));

            personListOne.Add(Randomizer.randomPerson());

            Console.WriteLine(personListOne.Count);


            Console.WriteLine(personListOne.Count);

            Console.ReadLine();

            string name = "";
            string surname = "";
            uint age = 0;
            Gender gender = Gender.Male;
            Person.insertPerson(name, surname, age, gender);
        }
    }
}
