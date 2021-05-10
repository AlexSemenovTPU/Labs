using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_Project
{
    class Program
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
        }
    }
}
