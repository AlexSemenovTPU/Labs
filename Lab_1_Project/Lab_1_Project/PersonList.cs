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

            var outputList = new Person[elementCount - 1];
            int indexNumber = 0;
            if ((elementCount == 0) || (elementCount <= index))
            {
                return Persons;
            }
            else
            {
                for (int i = 0; i < elementCount; i++)
                {
                    if (i != index - 1)
                    {
                        outputList[indexNumber] = Persons[i];
                        indexNumber++;
                    }
                }
                _localPersonArray = outputList;
                return Persons;
            }
        }

        /// <summary>
        /// Метод вывода списка в консоль
        /// </summary>
        /// <returns>Список персон построчно</returns>
        public string ShowList(string personInfo)
        {
            int elementCount = Count;
            if (elementCount > 0)
            {
                for (int i = 0; i < elementCount; i++)
                {
                    personInfo = personInfo + Person.Info(Persons[i]) + "\n";
                }
                return personInfo;
            }
            else
            {
                return "Список пуст";
            }
        }

        /// <summary>
        /// Поиск и вывод персоны по индексу в консоль
        /// </summary>
        /// <returns>Персона согласно индексу</returns>
        public Person SearchByIdnex(int index)
        {
            int elementCount = Count;

            if ((elementCount == 0) || (elementCount <= index)) 
            { 
                return new Person("", "", 0, Gender.Male); 
            }
            else
            {
                return Persons[index - 1];
            }
        }

        /// <summary>
        /// Осуществляет поиск индексов элементов при наличии их в списке
        /// </summary>
        /// <returns>Массив индексов, согласно условиям</returns>
        public uint[] IndexSearch(string name, string surname)
        {
            uint[] index = new uint[0];
            int elementCount = Count;

            for (uint i = 0; i < elementCount; i++)
            {
                if ((_localPersonArray[i].Name == name) || (_localPersonArray[i].Surname == surname))
                {
                    Array.Resize<uint>(ref index, index.Length + 1);
                    index[index.Length - 1] = i;
                }
            }
            return index;
        }

    }
}
