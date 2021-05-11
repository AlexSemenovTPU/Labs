using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Console.WriteLine("Press any key to start...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Generation of 7 random people...");
            Console.WriteLine();
            Console.ReadKey();

            var listOfPersons = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                listOfPersons.Add(Randomizer.CreateRandomPerson());
            }

            Console.WriteLine("A list of persons has been sucсessfully created!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Randomly generated list:\n");


            Console.WriteLine(listOfPersons.ShowList());


            Console.ReadKey();
        }
    }
}
