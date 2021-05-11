﻿using System;
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
        static public void RandomPerson(Person person)
        {

            if (_rnd.Next(1, 3) == 1) 
            { 
                person.Gender = Gender.Male; 
            }
            else 
            {
                person.Gender = Gender.Female; 
            }

            if (person.Gender == Gender.Male) 
            { 
                person.Name = _maleNames[_rnd.Next(0, _maleNames.Count)]; 
            }
            else 
            {
                person.Name = _femaleNames[_rnd.Next(0, _femaleNames.Count)]; 
            }

            person.Surname = _surnames[_rnd.Next(0, _surnames.Count)];
            
            if (person.Gender == Gender.Female)
            {
                person.Surname += "а";
            }

        }

        public static Person CreateRandomPerson()
        {
            if (_rnd.Next(0,2) != 0)
            {
                return CreateChild();
            }
            else
            {
                return CreateAdult();
            }
        }

        public static Adult CreateAdult(bool married = false)
        {
            var randomAdult = new Adult();
            RandomPerson(randomAdult);
            randomAdult.Age = _rnd.Next(Adult.MinAdultAge, Adult.MaxAdultAge);


            if (!married)
            {
                randomAdult.IsMarried = _rnd.Next(2) == 0 ? false : true;
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

            randomAdult.Job = jobs[_rnd.Next(0, jobs.Count)];
            GetPasportData(randomAdult);
            return randomAdult;
        }

        private static void GetPasportData(Adult adult)
        {
            var _passport = _rnd.Next(100000000, 999999999).ToString();
            adult.Passport = _passport;
        }

        public static Child CreateChild()
        {
            Child randomChild = new Child();
            RandomPerson(randomChild);
            randomChild.Age = _rnd.Next(Child.MinChildAge, Child.MaxChildAge);

            bool hasMother = _rnd.Next(0, 2) != 0;

            if (hasMother)
            {
                randomChild.Mother = CreateAdult(true);
            }

            bool hasFather = _rnd.Next(0, 2) != 0;

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

            randomChild.Institution = institution[_rnd.Next(0, institution.Count)];

            return randomChild;
        }
    }
}
