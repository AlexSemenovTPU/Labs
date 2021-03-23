﻿using System;
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
        private int _age;

        /// <summary>
        /// Возраст персоны
        /// </summary>
        public int Age 
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
        public Person(string name, string surnme, int age, Gender gender)
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
            string outGender;

            if (this.Gender == Gender.Male)
            {
                outGender = "Мужской";
            }
            else
            {
               outGender = "Женский";
            }

            return $"Имя: {this.Name} " +
                $"Фамилия: {this.Surname} " +
                $"Возраст: {this.Age} " +
                $"Пол: {outGender}; ";
        }

        /// <summary>
        /// Проверка имени/фамилии на соответствие требованиям
        /// </summary>
        /// <param name="name"></param>
        public static void CorrectName(string name)
        {
            //TODO: Попробовать объединитьs +
            Regex pattern = new Regex(@"((^([а-яА-Я])+$)|(^([а-яА-Я])+(\s|-)([а-яА-Я])+$))");

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
        public static void CorrectAge(int age)
        {
            
            if ((age >= Const.maxAge) || (age <= Const.minAge))
            {
                throw new ArgumentException(
                    $"Возраст должен быть меньше {Const.maxAge} или больше {Const.minAge}!");
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
    /// <summary>
    /// Глабальные переменные
    /// </summary>
    public class Const
    {
        public const int maxAge = 118;
        public const int minAge = 0;
    }

    
}


//Regex pattern = new Regex(@"((^([a-zA-Z])+$)|(^([a-zA-Z])+(\s|-)([a-zA-Z])+$))|((^([а-яА-Я])+$)|(^([а-яА-Я])+(\s|-)([а-яА-Я])+$))");