using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NodeUtil
{
    class NodeConnection
    {
        public TcpClient Connection;

        public NodeConnection()
        {


        }

        public void HeartBeat()
        {
            int bytecount = Encoding.ASCII.GetByteCount("60");
            byte[] senddata = new byte[bytecount];

            NetworkStream stream = Connection.GetStream();
            stream.Write(senddata, 0, bytecount);

        }

        public void Connect(IPAddress TargetAddress)
        {
            Connection.BeginConnect(TargetAddress, 6100, new AsyncCallback(Callback), Connection);
        }

        public void Send()
        {

        }

        public void Callback(IAsyncResult result)
        {
            Debug.WriteLine("Connected to Device");

            Connected;

            


        }

        public event EventHandler Connected;

        private enum DataType
        {
            HeartBeat,
            Message,
        }

    }
}
