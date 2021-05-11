﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_2_Project
{
    /// <summary>
    /// Взрослый.
    /// </summary>
    public class Adult : Person 
    {
        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        public const int MinAdultAge = 18;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        public const int MaxAdultAge = 118;

        public override int Age
        {
            get => _age;
            set
            {
                if ((value < MinAdultAge) || (value > MaxAdultAge))
                {
                    throw new ArgumentException(
                        $"Возраст должен быть меньше {MaxAdultAge} или больше {MinAdultAge}!");
                }
            }

        }

        /// <summary>
        /// Поле паспорта
        /// </summary>
        private string _passport;

        /// <summary>
        /// Паспортные данные
        /// </summary>
        public string Passport
        {
            get => _passport;
            set
            {
                const string pattern = @"^[0-9]{10}$";
                Regex regex = new Regex(pattern);
                if (value.Length != 10 || regex.IsMatch(value.ToString()) == true)
                {
                    throw new ArgumentException("Паспортные данные должны содержать " +
                        "10 чисел");
                }
                _passport = value;
            }
        }

        /// <summary>
        /// Семейное положение
        /// </summary>
        public bool IsMarried { get; set; }
        
        /// <summary>
        /// Супруг(а)
        /// </summary>
        public Adult Partner { get; set; }

        /// <summary>
        /// Ребенок
        /// </summary>
        public Adult Child { get; set; }

        /// <summary>
        /// Место работы
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// Вывод информаии о персоне
        /// </summary>
        public override string Info
        {
            get
            {
                string partner = Partner != null
                    ? $"{Partner.Name} {Partner.Surname}"
                    : "Нет партнера";
                string child = Child != null
                    ? $"{Child.Name} {Child.Surname}"
                    : "Нет детей";
                string job = Job != null
                    ? $"{Job}"
                    : "Нет";

                return base.Info +
                    $"\n\tПаспортные данные: {Passport}\n" +
                    $"\tСупруг(а): {partner}\n" +
                    $"\tДети: {child}\n" +
                    $"\tМесто работы: {job}";
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="passport"></param>
        /// <param name="job"></param>
        public Adult(string name, string surname, int age,
           Gender gender, string passport, string job) : base(name, surname, age, gender)
        {
            Passport = passport;
            Job = job;
        }

        /// <summary>
        /// Поиск работы
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public string FindJob(string job)
        {
            Job = job;

            return $"{Name} {Surname} работает в {job}";
        }

        public Adult() : this("Неизвестно", "Неизвестно", 0, Gender.Male,
            "0000000000", "Нет") { }
    }
}
