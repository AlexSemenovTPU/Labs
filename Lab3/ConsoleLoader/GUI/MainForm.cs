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
    public partial class MainForm : Form
    {

        public List<TransportBase> transportList = new List<TransportBase>();

        private static List<TransportBase> _ListForSearch = new List<TransportBase>();

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<TransportBase>));

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddTransport_Click(object sender, EventArgs e)
        {
            AddTransportForm addTransportForm = new AddTransportForm();
            addTransportForm.SendDataFromFormEvent += AddTransportEvent;
            addTransportForm.ShowDialog();
        }

        private void RemoveTransport_Click(object sender, EventArgs e)
        {
            if (DataGridTransport.RowCount < 1) return;

            var transportRemoval = DataGridTransport.CurrentRow.DataBoundItem;
            transportList.Remove((TransportBase)transportRemoval);
            ShowList(transportList);
        }

        public void AddTransportEvent(object sender, TransportEventArgs e)
        {
            transportList.Add(e.SendingTransport);
            ShowList(transportList);
        }

        private void ShowList(List<TransportBase> transportList)
        {
            DataGridTransport.DataSource = null;
            DataGridTransport.DataSource = transportList;
        }

        public void AddSearchTransportEvent(object sender, TransportEventArgs e)
        {
            _ListForSearch.Add(e.SendingTransport);
            ShowList(_ListForSearch);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            SearchForm.TakeList(transportList);
            searchForm.SendDataFromFormEvent += AddSearchTransportEvent;
            searchForm.ShowDialog();
        }
    }
}
