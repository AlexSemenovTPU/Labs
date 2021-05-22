using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleLoader
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Выберите действие:\n" +
                    "\t1 - Вычисление затраченного топлива машиной;\n" +
                    "\t2 - Вычисление затраченного топлива " +
                    "машиной-гибридом;\n" +
                    "\t3 - Вычисление затраченного топлива вертолетом;\n" +
                    "\t4 - Вычисление объёма египетской силы;\n");
                var Key = Console.ReadLine();
                switch (Key)
                {
                    case "1":
                        {
                            GetFuelQuantityInfo(AddConsoleData.
                                GetNewCarFromKeyboard());
                            break;
                        }
                    case "2":
                        {
                            GetFuelQuantityInfo(AddConsoleData.
                                GetNewCarFromKeyboard());
                            break;
                        }
                    case "3":
                        {
                            GetFuelQuantityInfo(AddConsoleData.
                                GetNewHelicopterFromKeyboard());
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Попробуйте ещё раз.");
                            break;
                        }
                }
            }
        }
        public static void GetFuelQuantityInfo(TransportBase transport)
        {
            Console.WriteLine($"Затраченное топливо " +
                $"{transport.FuelQuantity} л.");
        }
    }
}
