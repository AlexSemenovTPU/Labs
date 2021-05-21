using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Базоввый класс для всех
    /// видов транспорта
    /// </summary>
    public abstract class TransportBase
    {
        /// <summary>
        /// Рачет колличества затраченного топлива
        /// </summary>
        public abstract double FuelQuantity { get; }

        public static double NumberCheck (double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Величина должна" +
                    "быть положительным числом!");
            }
            else
            {
                return number;
            }
        }

    }
}
