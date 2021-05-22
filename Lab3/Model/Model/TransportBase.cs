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
        /// Наименоание транспорта
        /// </summary>
        private string _name;

        /// <summary>
        /// Ниаменование транспорта
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Наименование не может" +
                        "быть пустой строкой или null!");
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected TransportBase() : this("Неизвестно")
        {

        }

        /// <summary>
        /// Конструктор класса TransportBase
        /// </summary>
        /// <param name="name">Наименование транспорта</param>
        protected TransportBase(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Рачет колличества затраченного топлива
        /// </summary>
        public abstract double FuelQuantity { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double NumberCheck (double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Величина должна" +
                    "быть положительным числом!");
            }
            else
            {
                return number;
            }
        }

    }
}
