using SocketTopics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Factory
{
    public class ClientService
    {
        #region property
        ITcpClient _tcpClient;
        private string _ip { get; }
        private string _port { get; }
        #endregion

        public ClientService(ITcpClient tcpClient, string ip, string port) 
        {
            _tcpClient = tcpClient;     
            _ip = ip;
            _port = port;
        }

        
    }
}
