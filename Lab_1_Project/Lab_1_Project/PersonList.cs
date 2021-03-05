﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    //TODO: RSDN+

    /// <summary>
    /// Класс описывающий абстракцию списка,
    /// содержащего обьекты класса Person
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив переменных типа Person
        /// </summary>
        private Person[] _localPersonArray = new Person[0];

        /// <summary>
        /// Массив переменных типа Person
        /// </summary>
        public Person[] Persons => _localPersonArray;

        /// <summary>
        /// Колличество персон в списке
        /// </summary>
        public int Count => _localPersonArray.Length;

        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        public void Add(Person newElement)
        {
            int elementCount = Count;

            Array.Resize(ref _localPersonArray, Count + 1);
            _localPersonArray[elementCount] = newElement;
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void DeleteAll()
        {
            Array.Clear(Persons, 0, Count);
            Array.Resize(ref _localPersonArray, 0);
        }

        //TODO: Не возвращать список персон +
        /// <summary>
        /// Удаление элемента в списке
        /// </summary>
        /// <returns>Отредактированный список</returns>
        public void ElementDelete(int index)
        {
            int elementCount = Count;

            var outputList = new Person[elementCount - 1];
            int indexNumber = 0;
            if ((elementCount == 0) || (elementCount <= index))
            {
                return "Список пуст или отсутствует индекс";
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
            }
        }

        /// <summary>
        /// Метод вывода списка в консоль
        /// </summary>
        /// <returns>Список персон построчно</returns>
        public string ShowList()
        {
            string outputList = "";
            int elementCount = Count;

            if (elementCount > 0)
            {
                for (int i = 0; i < elementCount; i++)
                {
                    outputList = outputList + Persons[i].Info() + "\n";
                }
                return outputList;
            }
            else
            {
                return "Список пуст";
            }
        }

        //TODO:rename +
        /// <summary>
        /// Поиск и вывод персоны по индексу в консоль
        /// </summary>
        /// <returns>Персона согласно индексу</returns>
        public Person SearchByIndex(int index)
        {
            int elementCount = Count;

            if ((elementCount == 0) || (elementCount <= index)) 
            { 
                //TODO: Упасть и обработать снаружи
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
                if ((_localPersonArray[i].Name == name) 
                    || (_localPersonArray[i].Surname == surname))
                {
                    Array.Resize<uint>(ref index, index.Length + 1);
                    index[index.Length - 1] = i;
                }
            }
            return index;
        }

    }
}
