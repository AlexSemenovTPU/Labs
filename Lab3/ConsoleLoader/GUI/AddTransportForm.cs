using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Transport;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class AddTransportForm : Form
    {
        public event EventHandler<TransportEventArgs> SendDataFromFormEvent;

        private const string _carItem = "Машина";

        private const string _hybridCarItem = "Машина-гибрид";

        private const string _helicipterItem = "Вертолет";


        public AddTransportForm()
        {
            InitializeComponent();
            TypeOfTransportBox.Items.Add(_carItem);
            TypeOfTransportBox.Items.Add(_hybridCarItem);
            TypeOfTransportBox.Items.Add(_helicipterItem);

            PowerBox.Visible = false;
            PowerLabel.Visible = false;
            PowerLabelUnits.Visible = false;

            TypeOfTransportBox.SelectedIndexChanged += FormElementChange;

            ButtonAdd.Enabled = false;

            NameBox.TextChanged += BottonShow;
            ConsumptionBox.TextChanged += BottonShow;
            DistanceBox.TextChanged += BottonShow;
            PowerBox.TextChanged += BottonShow;

            #if !DEBUG
            {
                GetRandomData.Visible = false;
            }
            #endif
        }

        private void Add_Click(object sender, EventArgs e)
        {
            switch (TypeOfTransportBox.Text)
            {
                case _carItem:
                    {
                        var car = new Car();
                        car.Name = NameBox.Text;
                        car.AverageConsumption = Double.Parse(ConsumptionBox.Text);
                        car.Distance = Double.Parse(DistanceBox.Text);
                        SendDataFromFormEvent(this, new TransportEventArgs(car));
                        break;
                    }
                case _hybridCarItem:
                    {
                        var hybridCar = new HybridCar();
                        hybridCar.Name = NameBox.Text;
                        hybridCar.SpecificConsumptionGasEngine = Double.Parse(ConsumptionBox.Text);
                        hybridCar.TravelTime = Double.Parse(DistanceBox.Text);
                        hybridCar.ElectricMotorPower = Double.Parse(PowerBox.Text);
                        SendDataFromFormEvent(this, new TransportEventArgs(hybridCar));
                        break;
                    }
                case _helicipterItem:
                    {
                        var helicopter = new Helicopter();
                        helicopter.Name = NameBox.Text;
                        helicopter.AverageConsumption = Double.Parse(ConsumptionBox.Text);
                        helicopter.FlightTime = Double.Parse(DistanceBox.Text);
                        SendDataFromFormEvent(this, new TransportEventArgs(helicopter));
                        break;
                    }
            }
            #if !DEBUG
            {
                Close();
            }
            #endif
        }

        private void FormElementChange(object sender, EventArgs e)
        {
            NameBox.Clear();
            ConsumptionBox.Clear();
            DistanceBox.Clear();
            PowerBox.Clear();

            PowerBox.Visible = false;
            PowerLabel.Visible = false;
            PowerLabelUnits.Visible = false;

            switch (TypeOfTransportBox.Text)
            {
                case _carItem:
                {
                        ConsumptionLabel.Text = "Средний расход:";
                        ConsumptionLabelUnits.Text = "л/100км";
                        DistanceLabel.Text = "Дистанция:";
                        DistanceLabelUnits.Text = "км";
                        break;
                }
                case _hybridCarItem:
                {
                        PowerBox.Visible = true;
                        PowerLabel.Visible = true;
                        PowerLabelUnits.Visible = true;

                        ConsumptionLabel.Text = "Удельный расход:";
                        ConsumptionLabelUnits.Text = "г/кВтч";
                        DistanceLabel.Text = "Время в пути:";
                        DistanceLabelUnits.Text = "ч";
                        break;
                }
                case _helicipterItem:
                {
                        ConsumptionLabel.Text = "Средний расход:";
                        ConsumptionLabelUnits.Text = "кг/ч";
                        DistanceLabel.Text = "Время полета:";
                        DistanceLabelUnits.Text = "ч";
                        break;
                }
            }
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^0-9]";
            Regex letterRegex = new Regex(letterPattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
            Regex letterRegex = new Regex(letterPattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                    || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }

        private void BottonShow(object sender, EventArgs e)
        {
            switch (TypeOfTransportBox.Text)
            {
                case _carItem:
                {
                        ButtonAdd.Enabled = NameBox.Text.Length > 0
                            && ConsumptionBox.Text.Length > 0
                            && DistanceBox.Text.Length > 0;
                        break;
                }
                case _helicipterItem:
                {
                        ButtonAdd.Enabled = NameBox.Text.Length > 0
                            && ConsumptionBox.Text.Length > 0
                            && DistanceBox.Text.Length > 0;
                        break;
                }
                case _hybridCarItem:
                {
                        ButtonAdd.Enabled = NameBox.Text.Length > 0
                            && ConsumptionBox.Text.Length > 0
                            && DistanceBox.Text.Length > 0
                            && PowerBox.Text.Length > 0;
                        break;
                }
            }
        }

        private void GetRandomData_Click(object sender, EventArgs e)
        {
            TypeOfTransportBox.Text = TypeOfTransportBox.Items
                [Randomizer.GetRandomNumber(0, TypeOfTransportBox.Items.Count)].
                ToString();

            switch (TypeOfTransportBox.Text)
            {
                case _carItem:
                {
                        NameBox.Text = Randomizer.GetRandomName();
                        ConsumptionBox.Text = Randomizer.GetRandomNumber(1, 40).
                            ToString();
                        DistanceBox.Text = Randomizer.GetRandomNumber(1, 1000).
                            ToString();
                        break;
                }
                case _hybridCarItem:
                {
                        NameBox.Text = Randomizer.GetRandomName();
                        ConsumptionBox.Text = Randomizer.GetRandomNumber(1, 40).
                            ToString();
                        DistanceBox.Text = Randomizer.GetRandomNumber(1, 24).
                            ToString();
                        PowerBox.Text = Randomizer.GetRandomNumber(1, 1000).
                            ToString();
                        break;
                }
                case _helicipterItem:
                {
                        NameBox.Text = Randomizer.GetRandomName();
                        ConsumptionBox.Text = Randomizer.GetRandomNumber(1, 80).
                            ToString();
                        DistanceBox.Text = Randomizer.GetRandomNumber(1, 24).
                            ToString();
                        break;
                }    
            }
        }
    }
}
