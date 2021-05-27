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

        private List<TransportBase> _transportList = new List<TransportBase>();

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<TransportBase>));

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AddTransport_Click(object sender, EventArgs e)
        {
            AddTransportForm addTransportForm = new AddTransportForm();
            addTransportForm.SendDataFromFormEvent += AddTransportEvent;
            addTransportForm.ShowDialog();
        }

        private void RemoveTransport_Click(object sender, EventArgs e)
        {
            var transportRemoval = DataGridTransport.CurrentRow.DataBoundItem;
            _transportList.Remove((TransportBase)transportRemoval);
            ShowList();
        }

        private void AddTransportEvent(object sender, TransportEventArgs e)
        {
            _transportList.Add(e.SendingTransport);
            ShowList();
        }

        private void ShowList()
        {
            DataGridTransport.DataSource = null;
            DataGridTransport.DataSource = _transportList;
        }
    }
}
