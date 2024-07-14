using SocketTopics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Strategy
{
    public class TcpListenerStrategy : ITcpListener
    {
        private TcpListener _listener;

        public TcpListenerStrategy()
        {

        }

        public bool Start(string ip, string port, string fileName)
        {
            return true;
        }
        public void Stop()
        {

        }

        public ITcpClient AcceptTcpClient()
        {
            TcpClient tcpClient = _listener.AcceptTcpClient();
            return new TcpClientStrategy(tcpClient);
        }
    }
}
