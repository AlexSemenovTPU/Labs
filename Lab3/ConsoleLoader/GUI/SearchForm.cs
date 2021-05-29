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

namespace GUI
{
    public partial class SearchForm : Form
    {
        public event EventHandler<TransportEventArgs> SendDataFromFormEvent;

        private static List<TransportBase> _listForSearch = new List<TransportBase>();


        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.BroadcastList += TakeList;

            foreach (TransportBase transportBase in _listForSearch)
            {
                if (transportBase is Car && CheckCarBox.Checked == true)
                {
                    SendDataFromFormEvent(this, new TransportEventArgs(transportBase));
                }

                if (transportBase is HybridCar && CheckHybridCarBox.Checked == true)
                {
                    SendDataFromFormEvent(this, new TransportEventArgs(transportBase));
                }

                if (transportBase is Helicopter && CheckHelicopterBox.Checked == true)
                {
                    SendDataFromFormEvent(this, new TransportEventArgs(transportBase));
                }

                if (CheckFuelBox.Checked == true && 
                    transportBase.FuelQuantity.Equals(Double.Parse(FuelBox.Text)))
                {
                    SendDataFromFormEvent(this, new TransportEventArgs(transportBase));
                }
            }
            
        }

        public void TakeList(object sender, TransportEventArgs e)
        {
            _listForSearch.Add(e.SendingTransport);
        }

    }
}
