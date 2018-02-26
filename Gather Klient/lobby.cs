using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gather_Klient
{
    public class lobby
    {
        public lobby()
        {

        }

        string _name;
        string _status;
        string _map;
        string _players;
        string _score;
        string _avg_elo;
        int _id;

        public string name
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

        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string map
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

        public string players
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

        public string score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }

        public string avg_elo
        {
            get
            {
                return _avg_elo;
            }
            set
            {
                _avg_elo = value;
            }
        }

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        
    }

    
}
