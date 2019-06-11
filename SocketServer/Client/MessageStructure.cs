using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MessageStructure : UserControl
    {
        public MessageStructure()
        {
            InitializeComponent();
        }

        #region Properties

        private string _nick;
        [Category("Custom Props")]
        public string Nick
        {
            get { return _nick; }
            set { _nick = value; userNickLBL.Text = value; }
        }

        private string _message;
        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; messageLBL.Text = value; }
        }

        private string _time;
        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; timeLBL.Text = value; }
        }

        #endregion
    }
}
