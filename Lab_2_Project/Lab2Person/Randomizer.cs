using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Project
{
    /// <summary>
    /// Класс для формироания рандомной персоны
    /// </summary>
    public class Randomizer
    {
        //TODO: RSDN
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
                "Алексей",
                "Александр",
                "Дмитрий",
                "Леонид",
                "Роман",
                "Евгений",
                "Иван",
                "Максим",
                "Захар",
                "Тимофей"
            };

            /// <summary>
            /// Лист женских имен
            /// </summary>
            var femaleNames = new List<string>()
            {
                "Анастасия",
                "Анна",
                "Мария",
                "Елена",
                "Дарья",
                "Алина",
                "Ирина",
                "Екатерина",
                "Арина",
                "Полина"
            };
            
            /// <summary>
            /// Лист фамилий
            /// </summary>
            var surnames = new List<string>()
            {
                "Семенов",
                "Логинов",
                "Иванов",
                "Смирнов",
                "Новиков",
                "Крылов",
                "Павлов",
                "Голубев",
                "Беляев",
                "Тарасов"
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
            
            if (gender == Gender.Female)
            {
                surname = surname + "а";
            }

            int age = Convert.ToInt32(_rnd.Next(Person.MinAge, Person.MaxAge));

            return new Person(name, surname, age, gender);
        }
    }
}
