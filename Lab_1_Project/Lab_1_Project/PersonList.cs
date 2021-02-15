using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class PersonList
    {
        private Person[] _localPersonArray = new Person[0];

        public Person[] Persons => _localPersonArray;

        public int Count => _localPersonArray.Length;

        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        public void Add(Person newelement)
        {
            int elementCount = Count;

            Array.Resize(ref _localPersonArray, Count + 1);
            _localPersonArray[elementCount] = newelement;
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void DeleteAll()
        {
            Array.Clear(Persons, 0, Count);
            Array.Resize(ref _localPersonArray, 0);
        }

        /// <summary>
        /// Удаление элемента в списке
        /// </summary>
        /// <returns>Отредактированный список</returns>
        public Person[] ElementDelete(int index)
        {
            int elementCount = Count;

            if (elementCount == 0) return Persons;
            if (elementCount <= index) return Persons;

            var outputList = new Person[elementCount - 1];
            int indexNumber = 0;

            for (int i = 0; i < elementCount; i++)
            {
                if (i != index)
                {
                    outputList[indexNumber] = Persons[i];
                    indexNumber++;
                }
            }
            _localPersonArray = outputList;
            return Persons;
        }

        /// <summary>
        /// Метод вывода списка в консоль
        /// </summary>
        /// <returns>Список персон построчно</returns>
        public string ShowList(string personInfo)
        {
            int elementCount = Count;

            for (int i = 0; i < elementCount; i++)
            {
                personInfo = personInfo + Person.Info(Persons[i]) + "\n";
            }
            return personInfo;

        }

        /// <summary>
        /// Поиск и вывод персоны по индексу в консоль
        /// </summary>
        /// <returns>Персона согласно индексу</returns>
        public string IndexSearch(int index)
        {
            int elementCount = Count;

            if (elementCount == 0) return "";
            if (elementCount <= index) return "";

            string searchPerson = Person.Info(Persons[index]);
            return searchPerson;
        }
    }
}
