using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    class PersonList
    {
        private Person[] _localPersonArray = new Person[1];

        public Person[] Persons => _localPersonArray;

        public int Count => _localPersonArray.Length;

        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        public void add(Person newelement)
        {
            int elementCount = Count;

            Array.Resize(ref _localPersonArray, Count + 1);
            _localPersonArray[elementCount] = newelement;
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void deleteAll()
        {
            Array.Clear(Persons, 0, Count);
            Array.Resize(ref _localPersonArray, 0);
        }

        /// <summary>
        /// Удаление элемента в списке
        /// </summary>
        /// <returns>Отредактированный список</returns>
        public Person[] elementDelete(int index)
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

        
    }
}
