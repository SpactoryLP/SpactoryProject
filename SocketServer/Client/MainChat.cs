using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ServerData;
using System.Threading;

namespace Client
{
    public partial class MainChat : UserControl
    {
        private static MainChat control;

        public static MainChat Instance
        {
            get
            {
                if (control == null)
                    control = new MainChat();
                return control;
            }
        }

        public Socket master;
        public string name;
        public string id;
        IPEndPoint ip;
        int mesCount = 0;

        public MainChat()
        {
            InitializeComponent();

            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ip = new IPEndPoint(IPAddress.Parse("10.0.0.6" /*server IP*/), 4242);
        }

        void Data_IN()
        {
            byte[] buffer;
            int readBytes;

            try
            {
                for (; ; )
                {
                    buffer = new byte[master.SendBufferSize];
                    readBytes = master.Receive(buffer);

                    if (readBytes > 0)
                    {
                        DataManager(new Packet(buffer));
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Server went offline!");
                Environment.Exit(0);
            }
        }

        void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Registration:
                    id = p.Gdata[0];
                    break;
                case PacketType.Chat:
                    //AllMes(listbox item).Items.Add(p.Gdata[0] + " " + p.Gdata[1] + ": " + p.Gdata[2]);
                    mesCount++;
                    this.BeginInvoke((Action)delegate()
                    {
                        if (p.Gdata[1] != nameTBX.Text)///sender name != current user's name
                        {
                            ShowMessageControl(p.Gdata[0], p.Gdata[1], p.Gdata[2], Color.LightBlue);
                            if (mesPanel.Controls.Count >= 4)
                            {
                                int change = mesPanel.VerticalScroll.Value + mesPanel.VerticalScroll.SmallChange * 30;
                                mesPanel.AutoScrollPosition = new Point(0, change);
                            }
                        }
                        else
                        {
                            ShowMessageControl(p.Gdata[0], p.Gdata[1], p.Gdata[2], Color.LightGreen);
                            if (mesPanel.Controls.Count >= 4)
                            {
                                int change = mesPanel.VerticalScroll.Value + mesPanel.VerticalScroll.SmallChange * 30;
                                mesPanel.AutoScrollPosition = new Point(0, change);
                            }
                        }
                        mesCount = 0;
                    });
                    break;

            }
        }

        void ShowMessageControl(string time, string nick, string message, Color color)
        {
            MessageStructure[] messages = new MessageStructure[mesCount];
            for(int i = 0; i < mesCount; i++)
            {
                messages[i] = new MessageStructure();
                messages[i].Nick = nick;
                messages[i].Time = time;
                messages[i].Message = message;
                messages[i].BackColor = color;

                mesPanel.Controls.Add(messages[i]);
            }
        }

        private void connectBTN_Click_1(object sender, EventArgs e)
        {
            try { master.Connect(ip); }
            catch { MessageBox.Show("The server is unavailable!"); }

            Thread t = new Thread(Data_IN);
            t.Start();
        }

        private void sendBTN_Click_1(object sender, EventArgs e)
        {
            if(ToSendTBX.Text != "")
            {
                Packet p = new Packet(PacketType.Chat, id);
                p.Gdata.Add(DateTime.Now.ToShortTimeString());
                p.Gdata.Add(nameTBX.Text);
                p.Gdata.Add(ToSendTBX.Text);
                master.Send(p.toBytes());
                ToSendTBX.Text = "";
            }
        }
    }
}