using System;
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
        public client()
        {
            InitializeComponent();
        }

        #region Instancias
        UdpClient _server = new UdpClient();
        #endregion

        #region Funciones
        private void butsend_Click(object sender, EventArgs e)
        {
            //Dirrección
            _server.Connect(txthost.Text, 8080);
            //Mensaje ha enviar
            Byte[] senddata = Encoding.ASCII.GetBytes(txtmessage.Text);
            _server.Send(senddata, senddata.Length);
        }
        #endregion
    }
}
