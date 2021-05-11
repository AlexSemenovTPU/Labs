using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_Project
{
    /// <summary>
    /// Ребенок
    /// </summary>
    public class Child : Person
    {
        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        public const int MinChildAge = 0;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        public const int MaxChildAge = 18;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get => _age;
            set
            {
                if ((value < MinChildAge) || (value > MaxChildAge))
                {
                    throw new ArgumentException(
                        $"Возраст должен быть меньше {MaxChildAge} или больше {MinChildAge}!");
                }
                _age = value;
            }

        }

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Учереждение
        /// </summary>
        public string Institution { get; set; }

        /// <summary>
        /// Информация о ребенке
        /// </summary>
        public override string Info
        {
            get
            {
                string parents;
                if ((Mother == null) && (Father == null))
                {
                    parents = "нет";
                }
                else if ((Mother == null) && (Father != null))
                {
                    parents = $"отец-одиночка - {Father.Name} {Father.Surname}";
                }
                else if ((Mother != null) && (Father == null))
                {
                    parents = $"мать-одиночка - {Mother.Name} {Mother.Surname}";
                }
                else
                {
                    parents = $"отец - {Father.Name} {Father.Surname}, " +
                        $"мать - {Mother.Name} {Mother.Surname}";
                }

                string institution = Institution != null
                    ? $"{Institution}"
                    : "нет";

                return base.Info +
                    $"\n\tРодители: {parents}\n" +
                    $"\tУчереждение: {institution}";
            }

            
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surame"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="mother"></param>
        /// <param name="father"></param>
        /// <param name="institution"></param>
        public Child(string name, string surame, int age,
            Gender gender, Adult mother, Adult father,
            string institution) : base(name, surame, age, gender)
        {
            Mother = mother;
            Father = father;
            Institution = institution;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Child() : this("Неизвестно", "Неизвестно", 10, Gender.Male,
            null, null, institution: "Нет") { }

        /// <summary>
        /// Знятие ребенка на день
        /// </summary>
        /// <returns></returns>
        public string CheckInterest()
        {
            return $"{Name} {Surname} смотрит YouTube" +
                $" весь день и не делает уроки";
        }
    }
}
