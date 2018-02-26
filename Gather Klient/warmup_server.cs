using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gather_Klient
{
   public class warmup_server
    {
        private string _name = "-";
        private string _map = "-";
        private string _players = "-";
        private string _ip = "";
        private short _port = 0;
        private int _id = 0;

        public warmup_server(string ip, short port, int id)
        {
            _ip = ip;
            _port = port;
            _id = id;
        }

        public string Name
        {
            get
            {
                return _name;
            }
                
            set
            {
                _name = value;
            }
        }

        public string Map
        {
            get
            {
                return _map;
            }
            set
            {
                _map = value;
            }
        }

        public string Players
        {
            get
            {
                return _players;
            }
            set
            {
                _players = value;
            }
        }

        public string Ip
        {
            get
            {
                return _ip;
            }          
        }

        public short Port
        {
            get
            {
                return _port;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
