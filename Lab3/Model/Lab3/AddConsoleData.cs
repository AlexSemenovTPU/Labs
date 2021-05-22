using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Transport;

namespace ConsoleLoader
{
    public class AddConsoleData
    {
        public static Car GetNewCarFromKeyboard()
        {
            var car = new Car();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Наименование транспорта: ");
                    car.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите средний расход, л/100км: ");
                    car.AverageConsumption = Parse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите пройденную дистанцию, км: ");
                    car.Distance = Parse();
                })                
            };
            actions.ForEach(SetValue);
            return car;
        }

        public static Hybrid GetNewHybridFromKeyboard()
        {
            var hybrid = new Hybrid();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Наименование транспорта: ");
                    hybrid.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите удельный расход топлива," +
                        " г/кВтч: ");
                    hybrid.SpecificConsumptionGasEngine = Parse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите время в пути, ч: ");
                    hybrid.TravelTime = Parse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите мощность " +
                        "электродвигателя, кВт: ");
                    hybrid.ElectricMotorPower = Parse();
                })
            };
            actions.ForEach(SetValue);
            return hybrid;
        }

        public static Helicopter GetNewHelicopterFromKeyboard()
        {
            var helicopter = new Helicopter();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Наименование транспорта: ");
                    helicopter.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите средний расход, кг/ч: ");
                    helicopter.AverageConsumption = Parse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Введите время полета, ч: ");
                    helicopter.FlightTime = Parse();
                })
            };
            actions.ForEach(SetValue);
            return helicopter;
        }

        public static double Parse()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
        }

        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

    }
}
