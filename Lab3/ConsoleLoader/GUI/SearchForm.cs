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

        private static List<TransportBase> _ListForSearch = new List<TransportBase>();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var searchedTransportList = new List<TransportBase>();
            foreach (TransportBase transportBase in _ListForSearch)
            {
                if (transportBase is Car)
                {
                    SendDataFromFormEvent(this, new TransportEventArgs(transportBase));
                }
            }
            
        }

        public static void TakeList(List<TransportBase> transportList)
        {
            foreach (TransportBase transportBase in transportList)
            {
                _ListForSearch.Add(transportBase);
            }
        }

    }
}
