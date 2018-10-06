using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NodeUtil
{
    class NodeConnection
    {
        private TcpClient Connection;

        public NodeConnection(IPAddress TargetAddress)
        {
            Connection.BeginConnect(TargetAddress, 6100, Callback, Connection);
        }

        public void HeartBeat()
        {

        }
        
        public void Send()
        {

        }

        public static void Callback(IAsyncResult result)
        {

        }

    }
}
