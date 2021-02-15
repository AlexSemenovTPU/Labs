using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    class Randomizer
    {

        private static Random _rnd = new Random();

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns>Экземпляр случайной персоны</returns>
        static public Person randomPerson()
        {

            string[] MaleNames = new string[10] { "Oliver", "Jack", "Harry", "Jacob", "Charley", "Thomas", "George", "Oscar", "James", "William" };
            string[] FemaleNames = new string[10] { "Melanie", "Florence", "Agatha", "Zoe", "Rebecca", "Ruth", "Barbara", "Amanda", "Victoria", "Irene" };
            string[] Surnames = new string[10] { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };

            string Name;
            string Surname;
            uint Age;
            Gender Gender;

            if (_rnd.Next(1, 3) == 1) { Gender = Gender.Male; }
            else { Gender = Gender.Female; }

            if (Gender == Gender.Male) { Name = MaleNames[_rnd.Next(0, 9)]; }
            else { Name = FemaleNames[_rnd.Next(0, 9)]; }

            Surname = Surnames[_rnd.Next(0, 9)];

            Age = Convert.ToUInt32(_rnd.Next(0, 118));

            Person returnPerson = new Person(Name, Surname, Age, Gender);
            return returnPerson;
        }
    }
}
