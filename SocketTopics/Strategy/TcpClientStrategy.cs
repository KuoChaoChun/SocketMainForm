using SocketTopics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Strategy
{
    public class TcpClientStrategy : ITcpClient
    {
        private TcpClient _tcpClient;

        public TcpClientStrategy()
        {
            _tcpClient = new TcpClient();
        }

        public TcpClientStrategy(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
        }

        public void ConformInfo(string ip, string port, string fileName, string savePath)
        {

        }

        public void Connect(string ip, int port)
        {
            _tcpClient.Connect(ip, port);
        }
        public void DisConnect()
        {

        }
        public string ReceiveMsg()
        {
            return string.Empty;
        }
        public void ReceiveFile(string savePath, string fileName)
        {

        }
    }
}
