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

        private static List<TransportBase> _listForSearch = new List<TransportBase>();

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<TransportBase>));

        public event EventHandler<TransportEventArgs> BroadcastList;

        private event EventHandler ListChanged;

        public MainForm()
        {
            InitializeComponent();

            //ClearButton.Visible = false;

        }

        public void AddTransport_Click(object sender, EventArgs e)
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

        private void AddTransportEvent(object sender, TransportEventArgs e)
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
            _listForSearch.Add(e.SendingTransport);
            ShowList(_listForSearch);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            

            foreach (TransportBase transportBase in transportList)
            {
                BroadcastList(this, new TransportEventArgs(transportBase));
            }

            searchForm.ShowDialog();
            searchForm.SendDataFromFormEvent += AddSearchTransportEvent;
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _listForSearch.Clear();
            DataGridTransport.DataSource = null;
        }


    }
}
