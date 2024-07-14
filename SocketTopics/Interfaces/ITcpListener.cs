using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Interfaces
{
    public interface ITcpListener
    {
        bool Start(string ip, string port, string fileName);
        void Stop();
        ITcpClient AcceptTcpClient();
    }
}
