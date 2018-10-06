using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NodeUtil
{
    public class NodeServer
    {
        public IPAddress LocalIP;
        public Dictionary<IPAddress, string> ClientPool;

        public NodeServer()
        {

        }

    }
}
