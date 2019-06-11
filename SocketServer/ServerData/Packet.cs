using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ServerData;
using System.Net;

namespace ServerData
{
    [Serializable]
    public class Packet
    {
        public List<string> Gdata;
        public int packetInt;
        public bool packetBool;
        public string senderID;
        public PacketType packetType;

        public Packet(PacketType type, string senderID)
        {
            Gdata = new List<string>();
            this.senderID = senderID;
            this.packetType = type;
        }

        public Packet(byte[] packetBytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(packetBytes);

            Packet p = (Packet)bf.Deserialize(ms);
            ms.Close();
            this.Gdata = p.Gdata;
            this.packetInt = p.packetInt;
            this.packetBool = p.packetBool;
            this.senderID = p.senderID;
            this.packetType = p.packetType;
        }

        public byte[] toBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();

            return bytes;
        }

        public static string getIP4Address()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress i in ips)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    if(i.ToString() == "10.0.0.6") //Check for IP that currently connected to network        (for now my WiFi Ip address)
                        return i.ToString();
                }
            }

            return "127.0.0.1";
        }
    }

    public enum PacketType
    {
        Registration,
        Chat,
        DelayMessage,
        RingMessage
    }
}