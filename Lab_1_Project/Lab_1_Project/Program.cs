using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Program
    {
        static void Main(string[] args)
        {

            PersonList personListOne = new PersonList();
            PersonList personListTwo = new PersonList();

            Console.WriteLine("Создание двух списков персон по 3 человека в каждом:");
            for (int i = 0; i < 3; i++)
            {
                personListOne.Add(Randomizer.randomPerson());
                personListTwo.Add(Randomizer.randomPerson());
            }

            Console.ReadLine();

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

            Console.WriteLine("Добавление нового человека в первый список:");
            personListOne.Add(Randomizer.randomPerson());

            Console.ReadLine();

            Console.WriteLine("Копирование второго человека из первого списка в конец второго:");
            personListTwo.Add(personListOne.SearchByIndex(2));

            ToConsole(personListOne, personListTwo);
            
            Console.ReadLine();

            Console.WriteLine("Удаление второго человека из первого списка:");
            personListOne.ElementDelete(2);

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

            Console.WriteLine("Очистка второго списка:");
            personListTwo.DeleteAll();
                        
            Console.ReadLine();

            personListOne.Add(insertPerson());

            Console.ReadLine();

            ToConsole(personListOne, personListTwo);

            Console.ReadLine();

        }

        /// <summary>
        /// Вывод списков персон в консоль
        /// </summary>
        static void ToConsole(PersonList personListOne, PersonList personListTwo)
        {
            Console.WriteLine("Содержимое первого списка:");
            Console.WriteLine(personListOne.ShowList());
            Console.WriteLine("Содержимое второго списка:");
            Console.WriteLine(personListTwo.ShowList());
        }

        /// <summary>
        /// Проверка корректности вводимых параметров.
        /// </summary>
        /// <param name="outputMessage">Параметр для проверки.</param>
        /// <param name="validationAction">Метод проверки.</param>
        private static void ValidateInput(string outputMessage, Action validationAction)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(outputMessage);
                    validationAction.Invoke();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} Попробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Введение персоны с клавиатуры
        /// </summary>
        /// <returns>Экземпляр введенной с кдавиатуры персоны</returns>
        private static Person insertPerson()
        {

            Person person = new Person();
            Console.WriteLine("Ввдедите данные о новой персоне");
            var validationAction = new List<Tuple<string, Action>>()
            {
                new Tuple<string, Action>
                (
                    "Имя:",
                    () =>
                    {
                        person.Name = Console.ReadLine();
                    }
                ),
                new Tuple<string, Action>
                (
                    "Фамилия:",
                    () =>
                    {
                        person.Surname = Console.ReadLine();
                    }
                ),
                new Tuple<string, Action>
                (
                    "Возраст:",
                    () =>
                    {
                        try
                        {
                            person.Age  = Int32.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            throw new ArgumentException("Возраст должен быть числом!");
                        }
                    }
                ),
                new Tuple<string, Action>
                (
                    "Пол:",
                    () =>
                    {
                        switch (Console.ReadLine())
                        {
                            case "М":
                            case "м":
                                person.Gender = Gender.Male;
                                break;
                            case "Ж":
                            case "ж":
                                person.Gender = Gender.Female;
                                break;
                            default:
                                throw new ArgumentException("Вам нужно выбрать 'М' или 'Ж'");
                        }
                    }
                ),
            };
            foreach (var action in validationAction)
            {
                ValidateInput(action.Item1, action.Item2);
            }
            return person;
        }

    }
}

