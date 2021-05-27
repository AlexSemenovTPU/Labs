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
        private TransportBase _sendingTransport;

        public TransportBase SendingTransport
        {
            get => _sendingTransport;
            private set
            {
                _sendingTransport = value;
            }
        }

        public TransportEventArgs(TransportBase sendingTransport)
        {
            SendingTransport = sendingTransport;
        }
    }
}
