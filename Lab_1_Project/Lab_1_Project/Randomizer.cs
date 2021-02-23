using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Randomizer
    {

        private static Random _rnd = new Random();

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns>Экземпляр случайной персоны</returns>
        static public Person randomPerson()
        {

            string[] maleNames = new string[10] { "Oliver", "Jack", "Harry", "Jacob", "Charley", "Thomas", "George", "Oscar", "James", "William" };
            string[] femaleNames = new string[10] { "Melanie", "Florence", "Agatha", "Zoe", "Rebecca", "Ruth", "Barbara", "Amanda", "Victoria", "Irene" };
            string[] surnames = new string[10] { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };

            Gender gender;
            if (_rnd.Next(1, 3) == 1) { gender = Gender.Male; }
            else { gender = Gender.Female; }

            string name;
            if (gender == Gender.Male) { name = maleNames[_rnd.Next(0, 9)]; }
            else { name = femaleNames[_rnd.Next(0, 9)]; }

            string surname = surnames[_rnd.Next(0, 9)];

            uint age = Convert.ToUInt32(_rnd.Next(18, 118));

            Person returnPerson = new Person(name, surname, age, gender);
            return returnPerson;
        }
    }
}
