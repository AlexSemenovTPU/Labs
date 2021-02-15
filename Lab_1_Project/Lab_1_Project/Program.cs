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
            PersonList personListOne = new PersonList();
            PersonList personListTwo = new PersonList();
            
            for (int i = 0; i < 3; i++)
            {
                personListOne.add(Randomizer.randomPerson());
                personListTwo.add(Randomizer.randomPerson());
            }

            personListOne.ShowList();
            personListTwo.ShowList();

            Console.ReadLine();

            string name = "";
            string surname = "";
            uint age = 0;
            Gender gender = Gender.Male;
            Person.insertPerson(name, surname, age, gender);
        }
    }
}
