using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Person
    {
        private uint _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age 
        { 
            get => _age;
            private set
            {
                const uint maximumValue = 118;
                const uint minimumValue = 0;
                if ((value >= maximumValue) || (value <= minimumValue))
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Age)} должен быть меньше {maximumValue}!");
                }
                _age = value;
            }
                
        }
        public Gender Gender { get; set; }

        public Person(string name, string surnme, uint age, Gender gender)
        {
            Name = name;
            Surname = surnme;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Вывод персоны на экран
        /// </summary>
        static public string Info(Person person)
        {
            return $"Имя: {person.Name} " +
            $"Фамилия: {person.Surname} " +
            $"Возраст: {person.Age} " +
            $"Пол: {person.Gender}; ";
        }
            
        /// <summary>
        /// Введение персоны с клавиатуры
        /// </summary>
        /// <returns>Экземпляр введенной с кдавиатуры персоны</returns>
        static public Person insertPerson(string name, string surname, uint age, string genderInsert)
        {
            Gender gender = Gender.Male;

            if (genderInsert == "Male") { gender = Gender.Male; }
            else { gender = Gender.Female; }

            Person Person = new Person(name, surname, age, gender);
            return Person;
        }
    }

    
}
