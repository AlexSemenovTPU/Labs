using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Person
    {
        private uint _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age 
        { 
            get => _age;
            private set
            {
                const uint maximumValue = 118;
                if (value >= maximumValue)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Age)} должен быть меньше {maximumValue}!");
                }
                _age = value;
            }
                
        }
        public Gender Gender { get; set; }

        public Person(string name, string surnme, uint age, Gender gender)
        {
            Name = name;
            Surname = surnme;
            Age = age;
            Gender = gender;
        }
    }

    
}
