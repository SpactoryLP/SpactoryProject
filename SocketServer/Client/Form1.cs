using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerData;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!MainPanel.Controls.Contains(MainChat.Instance))
            {
                MainPanel.Controls.Add(MainChat.Instance);
                MainChat.Instance.Dock = DockStyle.Fill;
                MainChat.Instance.BringToFront();
                MainChat.Instance.Show();
            }
            else
            {
                MainChat.Instance.BringToFront();
                MainChat.Instance.Show();
            }
        }
    }
}