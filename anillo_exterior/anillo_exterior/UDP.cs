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
            //Carga form iniciamos thread en la función serverThread
            Thread thread = new Thread(serverThread);            
            thread.Start();
        }

        public void serverThread()
        {           
            while (true)
            {   
                //Array que coge los valores recibimos del cliente
                Byte[] receiveBytes = server.Receive(ref client);
                //Traducimos array
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
