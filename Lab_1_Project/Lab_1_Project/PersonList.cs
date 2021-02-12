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
    }
}
