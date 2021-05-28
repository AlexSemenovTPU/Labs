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
            ShowList();
        }

        public void AddTransportEvent(object sender, TransportEventArgs e)
        {
            transportList.Add(e.SendingTransport);
            ShowList();
        }

        private void ShowList()
        {
            DataGridTransport.DataSource = null;
            DataGridTransport.DataSource = transportList;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
