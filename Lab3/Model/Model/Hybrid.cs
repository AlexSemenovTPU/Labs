using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Transport
{
    //TODO: XML
    //TODO: naming
    public class Hybrid : TransportBase
    {
        /// <summary>
        /// Удельный расход г/кВтч
        /// </summary>
        private double _specificConsumptionGasEngine;

        /// <summary>
        /// Мощность электродвигателя кВт
        /// </summary>
        private double _electricMotorPower;

        /// <summary>
        /// Время в пути
        /// </summary>
        private double _travelTime;


        /// <summary>
        /// Удельный расход г/кВтч
        /// </summary>
        public double SpecificConsumptionGasEngine
        {
            get
            {
                return _specificConsumptionGasEngine;
            }
            set
            {
                NumberCheck(value);
                _specificConsumptionGasEngine = value;
            }
        }

        /// <summary>
        /// Пройденое расстояние
        /// </summary>
        public double TravelTime
        {
            get
            {
                return _travelTime;
            }
            set
            {
                NumberCheck(value);
                _travelTime = value;
            }
        }

        /// <summary>
        /// Мощность электродвигателя
        /// </summary>
        public double ElectricMotorPower
        {
            get
            {
                return _electricMotorPower;
            }
            set
            {
                NumberCheck(value);
                _electricMotorPower = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Hybrid() : this("Неизвестно", 0, 0, 0)
        {

        }

        /// <summary>
        /// Конструктор класса Hybrid
        /// </summary>
        /// <param name="name">Наименование транспорта</param>
        /// <param name="specificConsumptionGasEngine">Удельный рсход
        /// топлива г/кВтч</param>
        /// <param name="distance">Пройденое расстояние</param>
        /// <param name="electricMotorPower">Мощность электродвигателя</param>
        public Hybrid(string name, double specificConsumptionGasEngine, 
            double travelTime, double electricMotorPower) : base(name)
        {
            SpecificConsumptionGasEngine = specificConsumptionGasEngine;
            TravelTime = travelTime;
            ElectricMotorPower = electricMotorPower;
        }

        /// <summary>
        /// Возращает количество затраченного топлива
        /// </summary>
        public override double FuelQuantity
        {
            get
            {
                return Math.Abs(SpecificConsumptionGasEngine * 
                    ElectricMotorPower * TravelTime / 725 / 4);
            }
        }
    }
}
