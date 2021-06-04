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
    /// <summary>
    /// Класс формы поиска
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Ивент для передачи данных 
        /// </summary>
        public event EventHandler<TransportEventArgs> SendDataFromFormEvent;

        /// <summary>
        /// Лист фильтрованных транспортных средств
        /// </summary>
        private static List<TransportBase> _listForSearch = new List<TransportBase>();

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка фильтрации транспорта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CheckCarBox.Checked == false &&
                CheckHybridCarBox.Checked == false &&
                CheckHelicopterBox.Checked == false &&
                CheckFuelBox.Checked == false) return;

            foreach (TransportBase transportBase in _listForSearch)
            {
                switch (transportBase)
                {
                    case Car _ when CheckCarBox.Checked:
                    case HybridCar _ when CheckHybridCarBox.Checked:
                    case Helicopter _ when CheckHelicopterBox.Checked:
                    {
                        //TODO:+    
                        SendDataFromFormEvent?.Invoke(this, new TransportEventArgs(transportBase));
                        break;    
                    }
                }

                if (CheckFuelBox.Checked && transportBase.FuelQuantity.ToString().
                    Contains(FuelBox.Text))
                {
                    //TODO:+
                    SendDataFromFormEvent?.Invoke(this, new TransportEventArgs(transportBase));
                }
            }
            Close();

        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="transportList"></param>
        public SearchForm (List<TransportBase> transportList)
        {
            _listForSearch = transportList;
        }

        /// <summary>
        /// Обработка ввода числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^0-9]";
            Regex letterRegex = new Regex(letterPattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }
    }
}
