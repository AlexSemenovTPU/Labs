using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Transport;

namespace GUI
{
    public class TransportEventArgs : EventArgs
    {
        public event EventHandler<TransportEventArgs> SendDataFromFormEvent;

        private static List<TransportBase> _listForSearch = new List<TransportBase>();

        private TransportBase _sendingTransport;

        public TransportBase SendingTransport
        {
            get => _sendingTransport;
            private set
            {
                _sendingTransport = value;
            }
        }

        public TransportEventArgs()
        {

        }

        public TransportEventArgs(TransportBase sendingTransport)
        {
            SendingTransport = sendingTransport;
        }



        private void AddTransportEvent(object sender, TransportEventArgs e)
        {
            _listForSearch.Add(e.SendingTransport);
        }
    }
}
