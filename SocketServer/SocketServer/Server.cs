using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ServerData;
using System.IO;
using System.Threading;

namespace SocketServer
{
    class Server
    {
        static Socket listenerSocket;
        static List<ClientData> _clients;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting server on {0}", Packet.getIP4Address());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clients = new List<ClientData>();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.getIP4Address()), 4242);
            listenerSocket.Bind(ip);

            Thread listenThread = new Thread(ListenThread);
            listenThread.Start();
        }

        static void ListenThread()
        {
            for(; ; )
            {
                listenerSocket.Listen(0);
                _clients.Add(new ClientData(listenerSocket.Accept()));
                Console.WriteLine(_clients.Count.ToString());
            }
        }

        public static void Data_IN(object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;
            byte[] buffer;
            int readBytes;

            try
            {
                for (; ; )
                {
                    buffer = new byte[clientSocket.SendBufferSize];
                    readBytes = clientSocket.Receive(buffer);

                    if (readBytes > 0)
                    {
                        Packet packet = new Packet(buffer);
                        DataManager(packet);
                    }
                }
            }
            catch(SocketException ex)
            {
                Console.WriteLine("A client disconnected!");
            }
        }

        public static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Chat:
                    foreach(ClientData c in _clients)
                        c.clientSocket.Send(p.toBytes());
                    break;
            }
        }
    }

    class ClientData
    {
        public Socket clientSocket;
        public Thread clientThread;
        public string id;

        public ClientData()
        {
            id = Guid.NewGuid().ToString();
            clientThread = new Thread(Server.Data_IN);
            clientThread.Start(clientSocket);
            SendRegistrationPacket();
        }
        public ClientData(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
            id = Guid.NewGuid().ToString();
            clientThread = new Thread(Server.Data_IN);
            clientThread.Start(clientSocket);
            SendRegistrationPacket();
        }

        public void SendRegistrationPacket()
        {
            Packet p = new Packet(PacketType.Registration, "server");
            p.Gdata.Add(id);
            clientSocket.Send(p.toBytes());
        }
    }
}
