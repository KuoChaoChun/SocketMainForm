using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketTopics.Interfaces
{
    public interface ITcpClient
    {
        void ConformInfo(string ip, int port, string fileName, string savePath);
        void Connect(string ip, int port);
        void DisConnect();
        string ReceiveMsg();
        void ReceiveFile(string savePath, string fileName);

    }
}
