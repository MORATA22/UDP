﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace cliente
{
    public partial class client : Form
    {
        UdpClient _server = new UdpClient();        
        public client()
        {
            InitializeComponent();
        }
        
        private void butsend_Click(object sender, EventArgs e)
        {
            _server.Connect(txthost.Text, 8080);
            Byte[] senddata = Encoding.ASCII.GetBytes("Hello Client");
            _server.Send(senddata, senddata.Length);
        }
    }
}
