using SocketTopics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Factory
{
    public class ListenerService
    {
        private ITcpListener _tcpListener;

        public ListenerService(ITcpListener tcpListener)
        {
            _tcpListener = tcpListener;
        }
    }
}
