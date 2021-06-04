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
using System.Xml.Serialization;

namespace GUI
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class MainForm : Form
    {
        //TODO: RSDN naming+
        /// <summary>
        /// Лист транспорта
        /// </summary>
        private List<TransportBase> _transportList = new List<TransportBase>();

        //TODO:+
        /// <summary>
        /// Лист фильтрованного трансорта
        /// </summary>
        private List<TransportBase> _listForSearch = new List<TransportBase>();

        /// <summary>
        /// На будующее
        /// </summary>
        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<TransportBase>));

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            ClearButton.Visible = false;
        }

        /// <summary>
        /// Кнопка открытия формы добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddTransport_Click(object sender, EventArgs e)
        {
            AddTransportForm addTransportForm = new AddTransportForm();
            addTransportForm.SendDataFromFormEvent += AddTransportEvent;
            addTransportForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTransport_Click(object sender, EventArgs e)
        {
            if (DataGridTransport.RowCount < 1) return;

            var transportRemoval = DataGridTransport.CurrentRow.DataBoundItem;
            _transportList.Remove((TransportBase)transportRemoval);
            ShowList(_transportList);
        }

        /// <summary>
        /// Обработчик события получения даннх из формы добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTransportEvent(object sender, TransportEventArgs e)
        {
            _transportList.Add(e.SendingTransport);
            ShowList(_transportList);
        }

        /// <summary>
        /// Вывод листа в DataGrid
        /// </summary>
        /// <param name="transportList"></param>
        private void ShowList(List<TransportBase> ListToShow)
        {
            DataGridTransport.DataSource = null;
            DataGridTransport.DataSource = ListToShow;
            DataGridTransport.Columns[0].HeaderText = "Наименование транспорта";
            DataGridTransport.Columns[1].HeaderText = "Затраченное топливо";
        }

        /// <summary>
        /// Обработчик события получения данных из формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddSearchTransportEvent(object sender, TransportEventArgs e)
        {
            _listForSearch.Add(e.SendingTransport);
            ShowList(_listForSearch);
        }

        /// <summary>
        /// Кнопка открытия формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            
            //?
            SearchForm searchForm1 = new SearchForm(_transportList);

            searchForm.FormClosed += VisibleButton;
            searchForm.SendDataFromFormEvent += AddSearchTransportEvent;
            searchForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка отчистки фильтрованного списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _listForSearch.Clear();
            DataGridTransport.DataSource = null;
            ClearButton.Visible = false;
        }

        /// <summary>
        /// Изменение видимости кнопки отчитски
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisibleButton (object sender, EventArgs e)
        {
            if (_listForSearch.Count < 1) return;

            ClearButton.Visible = true;
        }
    }
}
