using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Gather_Klient
{
   public class network
    {
        byte[] r_data = new byte[1024]; // recieved data
        UdpClient m_client;
        IPEndPoint server = new IPEndPoint(IPAddress.Parse("185.81.165.148"), 1338);
        byte[] server_down = { 0xFA, 0x06 };

        public bool connect_to_server()
        {
            try
            {
                m_client = new UdpClient(); // init port
                m_client.Connect(server); // connect to server
                m_client.Client.ReceiveTimeout = 5000; // we set recieve timeout for 1s
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private byte[] build_packet(byte cmd, List<string> data)
        {
            int totalDataSize = 0;
            List<byte[]> t_data = new List<byte[]>();
            byte seporator = 0xDA;
            byte[] s_packet;

            for (int i = 0; i <= data.Count - 1; i++)
            {
                t_data.Add(Encoding.UTF8.GetBytes(data[i]));
                totalDataSize += t_data[i].Length;
            }

            s_packet = new byte[(totalDataSize + 2) + (data.Count)];

            s_packet[0] = cmd;
            s_packet[(totalDataSize + 1) + (data.Count)] = 0x00;

            int packetSize = 1;

            for (int i = 0; i <= data.Count - 1; i++)
            {
                Array.Copy(t_data[i], 0, s_packet, packetSize, t_data[i].Length);
                packetSize += t_data[i].Length + 1;
                s_packet[packetSize - 1] = seporator;
            }

            return s_packet;

        }


        public byte[] send_and_recieve(byte cmd, List<string> data)
        {
            try
            {
                byte[] s_packet = build_packet(cmd, data); // data that are going to send we send
                m_client.Send(s_packet, s_packet.Length);
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                r_data = m_client.Receive(ref sender);

                return r_data;

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message + "\n" + ex.StackTrace); - only for debug 
                m_client.Close(); // close port
                return server_down;
            }

        }


        public List<string> extract_data(byte[] data)
        {
            string dcuf_data = Encoding.UTF8.GetString(data).Remove(0, 2);
            string[] uf_data = dcuf_data.Split((char)65533);

            List<string> f_data = new List<string>();
            for (int i = 0; i <= uf_data.Length - 1; i++)
            {
                f_data.Add(uf_data[i].Trim());
            }
            return f_data;
        }

        public bool send_data(byte cmd, List<string> data)
        {
            try
            {

                byte[] s_packet = build_packet(cmd, data); // data that are going to send we send
                m_client.Send(s_packet, s_packet.Length);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public byte[] listen()
        {
            try
            {
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                r_data = m_client.Receive(ref sender);

                return r_data;
            }
            catch (Exception ex)
            {
                r_data[0] = 0x17; // failed
                return r_data;
            }
        }


    }
}
