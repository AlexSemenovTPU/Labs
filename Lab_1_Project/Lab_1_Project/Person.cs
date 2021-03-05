using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_1_Project
{
    //TODO: RSDN+
    /// <summary>
    /// Класс персон
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя персоны
        /// </summary>
        private string _name;

        /// <summary>
        /// Имя персоны
        /// </summary>
        public string Name 
        { 
            get => _name;
            private set
            {
                CorrectName(value);
                _name = CorrectRegister(value);
            } 
        }
        /// <summary>
        /// Фамилия персоны
        /// </summary>
        private string _surname;

        /// <summary>
        /// Фамилия персоны
        /// </summary>
        public string Surname 
        { 
            get => _surname;
            private set
            {
                CorrectName(value);
                _surname = CorrectRegister(value);
            } 
        }

        /// <summary>
        /// Возраст персоны
        /// </summary>
        private uint _age;

        /// <summary>
        /// Возраст персоны
        /// </summary>
        public uint Age 
        { 
            get => _age;
            private set
            {
                CorrectAge(value);
                _age = value;
            }
                
        }

        /// <summary>
        /// Пол персоны
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Пол персоны
        /// </summary>
        public Gender Gender 
        { 
            get => _gender; 
            private set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Конструктор класса Person
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surnme"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
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
        public string Info()
        {
            return $"Имя: {this.Name} " +
                $"Фамилия: {this.Surname} " +
                $"Возраст: {this.Age} " +
                $"Пол: {this.Gender}; ";
        }

        /// <summary>
        /// Проверка имени/фамилии на соответствие требованиям
        /// </summary>
        /// <param name="name"></param>
        public static void CorrectName(string name)
        {
            //TODO: Попробовать объединитьs +
            Regex pattern = new Regex(@"((^([a-zA-Z])+$)|(^([a-zA-Z])+(\s|-)([a-zA-Z])+$))
            |((^([а-яА-Я])+$)|(^([а-яА-Я])+(\s|-)([а-яА-Я])+$))");

            if (!pattern.IsMatch(name))
            {
                throw new ArgumentException("Имя и фамилия могут содержать" +
                    "только русские или английские символы!");
            }
        }

        /// <summary>
        /// Проверка возраста на соответствие требованиям
        /// </summary>
        /// <param name="age"></param>
        public static void CorrectAge(uint age)
        {
            const uint maximumValue = 118;
            const uint minimumValue = 0;
            if ((age >= maximumValue) || (age <= minimumValue))
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(Age)} должен быть меньше {maximumValue} или больше {minimumValue}!");
            }
        }

        /// <summary>
        /// Приведение имени/фамилии к правельному регистру
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Имя/фамилия с заглавной буквы</returns>
        private string CorrectRegister (string word)
        {
            return word.Substring(0, 1).ToUpper() +
                word.Substring(1).ToLower();
        }
    }

    
}
