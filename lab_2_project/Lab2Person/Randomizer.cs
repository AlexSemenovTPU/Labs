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
        /// Лист мужских имен
        /// </summary>
        private static List<string> _maleNames = new List<string>()
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
        private static List<string> _femaleNames = new List<string>()
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
        private static List<string> _surnames = new List<string>()
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

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns>Экземпляр случайной персоны</returns>
        static public Person RandomPerson()
        {
            int age = Convert.ToInt32(_rnd.Next(Person.MinAge, Person.MaxAge));

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
                name = _maleNames[_rnd.Next(0, _maleNames.Count)]; 
            }
            else 
            { 
                name = _femaleNames[_rnd.Next(0, _femaleNames.Count)]; 
            }

            string surname = _surnames[_rnd.Next(0, _surnames.Count)];
            
            if (gender == Gender.Female)
            {
                surname = surname + "а";
            }

            Person person = new Person(name, surname, age, gender);

            if (person.Age <= 18)
            {
                return CreateRandomChild();
            }
            else
            {
                return CreateRandomAdult();
            }


        }
    }
}
