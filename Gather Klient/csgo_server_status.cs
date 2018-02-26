using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Gather_Klient
{
    public class csgo_server_status
    {
        public void update_status(ref warmup_server server)
        {
            UdpClient server_link = new UdpClient(server.Ip, server.Port);

            try
            {               

                byte[] packet = { 0xff, 0xff, 0xff, 0xff, 0x54, 0x53, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x20, 0x45, 0x6E, 0x67, 0x69, 0x6E, 0x65, 0x20, 0x51, 0x75, 0x65, 0x72, 0x79, 0x00 };

                server_link.Send(packet, packet.Count());

                byte[] r_buf = new byte[1024];
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                r_buf = server_link.Receive(ref sender);



                string data = System.Text.Encoding.ASCII.GetString(r_buf);
                data += (char)0x00;
                string[] temp;
                temp = data.Split((char)0x00);
                server.Name = (temp[0].Remove(0, 6)); // server name
                server.Map = (temp[1]); // server map
                byte[] test = System.Text.Encoding.ASCII.GetBytes(temp[4]);
                if (test.Count() > 2)
                {
                    server.Players = test[2].ToString() + "/" + test[3].ToString(); // current players/max players
                }
                else // means server is empty and split 0x00 does not work
                {
                    test = System.Text.Encoding.ASCII.GetBytes(temp[5]);
                    server.Players = "0/" + test[0].ToString(); // current players/max players
                }


                server_link.Close();
                //return server_info;
            }
            catch 
            {
                //List<string> server_info = new List<string>();
                //return server_info;
                server_link.Close();
            }

        }
    }
}
