using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gather_Klient
{
    public class me
    {
        string _steamid;
        string _username;
        string _lobby_status;
        long _s_hash;
        int _lobby_id = -1;
        
        bool _am_i_in_lobby;
        bool _ready_window_open;
        bool _am_i_ready;
        bool _lobby_window_open;


        public string lobby_status
        {
            get
            {
                return _lobby_status;
            }
            set
            {
                _lobby_status = value;
            }
        }
        public string steamid
        {
            get
            {
                return _steamid;
            }
            set
            {
                _steamid = value;
            }
        }

        public int lobby_id
        {
            get
            {
                return _lobby_id;
            }
            set
            {
                _lobby_id = value;
            }
        }

        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public long s_hash
        {
            get
            {
                return _s_hash;
            }
            set
            {
               _s_hash = value;
            }
        }


        public bool am_i_in_lobby
        {
            get
            {
                return _am_i_in_lobby;
            }
            set
            {
                _am_i_in_lobby = value;
            }
        }


        public bool ready_window_open
        {
            get
            {
                return _ready_window_open;
            }
            set
            {
                _ready_window_open = value;
            }
        }

        public bool am_i_ready
        {
            get
            {
                return _am_i_ready;
            }
            set
            {
                _am_i_ready = value;
            }
        }

        public bool lobby_window_open
        {
            get
            {
                return _lobby_window_open;
            }
            set
            {
                _lobby_window_open = value;
            }
        }

    }
}
