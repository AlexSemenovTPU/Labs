using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Randomizer
    {
        private static Random _random = new Random();

        private static List<string> _names = new List<string>()
        {
            "Ребросближатель",
            "Цианстильбен",
            "Риттингерит",
            "Десланозид",
            "Шляхетство",
            "Зоометрия",
            "Карбовакс",
            "Топоплан",
            "Евтерпа",
            "Доризм"
        };

        public static string GetRandomName()
        {
            return _names[_random.Next(0, _names.Count)];
        }

        public static double GetRandomNumber(int minValue,int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}
