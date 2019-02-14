using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace anillo_exterior
{
    public partial class UDP : Form
    {       
        UdpClient server = new UdpClient(8080);
        IPEndPoint client = null;
        string mensaje = string.Empty;


        public UDP()
        {
            InitializeComponent();
        }
        private void UDP_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(serverThread);            
            thread.Start();
        }

        public void serverThread()
        {           
            while (true)
            {                
                Byte[] receiveBytes = server.Receive(ref client);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                mensaje = client.Address.ToString() + ":" + returnData.ToString();

                if (labhost.InvokeRequired)
                {
                    labhost.Invoke((MethodInvoker)delegate { labhost.Text = mensaje; });
                }
                else
                {
                    labhost.Text = mensaje;
                }                              
            }
        }        
    }
}
