using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    /// <summary>
    /// Класс для формироания рандомной персоны
    /// </summary>
    public class Randomizer
    {
        /// <summary>
        /// Приватный класс Random
        /// </summary>
        private static Random _rnd = new Random();

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns>Экземпляр случайной персоны</returns>
        static public Person randomPerson()
        {
            /// <summary>
            /// Лист мужских имен
            /// </summary>
            var maleNames = new List<string>()
            {
                "Oliver",
                "Jack",
                "Harry",
                "Jacob",
                "Charley",
                "Thomas",
                "George",
                "Oscar",
                "James",
                "William"
            };
            /// <summary>
            /// Лист женских имен
            /// </summary>
            var femaleNames = new List<string>()
            {
                "Melanie",
                "Florence",
                "Agatha",
                "Zoe",
                "Rebecca",
                "Ruth",
                "Barbara",
                "Amanda",
                "Victoria",
                "Irene"
            };
            /// <summary>
            /// Лист фамилий
            /// </summary>
            var surnames = new List<string>()
            {
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor"
            };
            
            Gender gender;
            if (_rnd.Next(1, 3) == 1) 
            { 
                gender = Gender.Male; 
            }
            else 
            { 
                gender = Gender.Female; 
            }

            string name;
            if (gender == Gender.Male) 
            { 
                name = maleNames[_rnd.Next(0, maleNames.Count)]; 
            }
            else 
            { 
                name = femaleNames[_rnd.Next(0, femaleNames.Count)]; 
            }

            string surname = surnames[_rnd.Next(0, surnames.Count)];

            //TODO: minage +
            int age = Convert.ToInt32(_rnd.Next(Const.minAge, Const.maxAge));

            return new Person(name, surname, age, gender);
        }
    }
}
