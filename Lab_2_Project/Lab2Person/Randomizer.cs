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
        //TODO: RSDN+
        /// <summary>
        /// Приватный класс Random
        /// </summary>
        private static Random _random = new Random();

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
        /// Заполнение базовых полей
        /// </summary>
        /// <returns>Экземпляр случайной персоны</returns>
        static public void RandomPerson(PersonBase person)
        {

            if (_random.Next(1, 3) == 1) 
            { 
                person.Gender = Gender.Male; 
            }
            else 
            {
                person.Gender = Gender.Female; 
            }

            if (person.Gender == Gender.Male) 
            { 
                person.Name = _maleNames[_random.Next(0, _maleNames.Count)]; 
            }
            else 
            {
                person.Name = _femaleNames[_random.Next(0, _femaleNames.Count)]; 
            }

            person.Surname = _surnames[_random.Next(0, _surnames.Count)];
            
            if (person.Gender == Gender.Female)
            {
                person.Surname += "а";
            }

        }

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns></returns>
        public static PersonBase CreateRandomPerson()
        {
            if (_random.Next(0,2) != 0)
            {
                return CreateChild();
            }
            else
            {
                return CreateAdult();
            }
        }

        /// <summary>
        /// Создание случайного взрослого
        /// </summary>
        /// <param name="married"></param>
        /// <returns></returns>
        public static Adult CreateAdult(bool married = false)
        {
            var randomAdult = new Adult();
            RandomPerson(randomAdult);
            randomAdult.Age = _random.Next(Adult.MinAdultAge, Adult.MaxAdultAge);


            if (!married)
            {
                randomAdult.IsMarried = _random.Next(2) == 0 ? false : true;
                if (randomAdult.IsMarried == true)
                {
                    randomAdult.Partner = CreateAdult(true);
                }
            }

            List<string> jobs = new List<string>()
            {
                "СО ЕЭС", "KFC", "КГБ",
                "Шаурма у Нурика", "Google", "ХГУ",
                "Пельменная", "Автомастерская", "Кофейня"
            };

            randomAdult.Job = jobs[_random.Next(0, jobs.Count)];
            GetPasportData(randomAdult);
            return randomAdult;
        }

        /// <summary>
        /// Создаание случайных паспортных данныых
        /// </summary>
        /// <param name="adult"></param>
        private static void GetPasportData(Adult adult)
        {
            var _passportSeries = _random.Next(1000, 9999).ToString();
            var _passportNumber = _random.Next(100000, 999999).ToString();
            string _passport = _passportSeries + _passportNumber;
            adult.Passport = _passport;
        }

        /// <summary>
        /// Создание случаайного ребенка
        /// </summary>
        /// <returns></returns>
        public static Child CreateChild()
        {
            Child randomChild = new Child();
            RandomPerson(randomChild);
            randomChild.Age = _random.Next(Child.MinChildAge, Child.MaxChildAge);

            bool hasMother = _random.Next(0, 2) != 0;

            if (hasMother)
            {
                randomChild.Mother = CreateAdult(true);
            }

            bool hasFather = _random.Next(0, 2) != 0;

            if (hasFather)
            {
                randomChild.Father = CreateAdult(true);
            }
            
            List<string> institution = new List<string>()
            {
                "№25", "№1",
                "Лицей", "Гимназия", "№322",
                "Пуфендуй", "Буратино",
                "Ромашка"
            };

            randomChild.Institution = institution[_random.Next(0, institution.Count)];

            return randomChild;
        }
    }
}
