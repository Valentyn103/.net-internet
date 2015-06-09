using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDown
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client = null;
        NetworkStream netStream = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            int servPort = Int32.Parse(txbServerPort.Text);
            listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Any, servPort);
                listener.Start();
            }
            catch (SocketException se)
            {
                listText.Items.Add(se.ErrorCode + ": " + se.Message);
            }
            ThreadStart threadstart = new ThreadStart(GetClientConnect);
            Thread thread = new Thread(threadstart);
            thread.Start();
        }

        public void GetClientConnect()
        {
            while (true)
            {
                try
                {
                    NetworkStream netStream = null;
                    byte[] rcvBuffer = new byte[32];
                    int bytesRcvd;
                    client = listener.AcceptTcpClient();
                    netStream = client.GetStream();
                    listText.Items.Add("Handling client - ");
                    int totalBytesEchoed = 0;
                    while ((bytesRcvd = netStream.Read(rcvBuffer, 0, rcvBuffer.Length)) > 0)
                    {
                        netStream.Write(rcvBuffer, 0, bytesRcvd);
                        totalBytesEchoed += bytesRcvd;
                    }
                    listText.Items.Add("echoed " + totalBytesEchoed + " bytes.");
                    netStream.Close();
                    client.Close();

                }
                catch (Exception exc)
                {
                    listText.Items.Add(exc.Message.ToString());
                    netStream.Close();
                }
                Thread.Sleep(1000);
            }
        }
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            String server = txbServerIp.Text;
            int servPort = Int32.Parse(txbServerPort.Text);
            TcpClient Myclient = null;
            try
            {
                Myclient = new TcpClient(server, servPort);
                ThreadStart threadstart = new ThreadStart(ReceiveString);
                Thread thread = new Thread(threadstart);
                thread.Start();
                listText.Items.Add("Connected to server... sending echo string");
            }
            catch (Exception ex)
            {
                listText.Items.Add(ex.Message);
            }
            finally
            {
                if (netStream != null)
                    netStream.Close();
                if (Myclient != null)
                    Myclient.Close();
            }
        }
        private void ReceiveString()
        {
            while (true)
            {
                try
                {
                    NetworkStream netStream = null;
                    byte[] byteBuffer = ASCIIEncoding.ASCII.GetBytes(txbSend.Text);
                    netStream = client.GetStream();
                    netStream.Write(byteBuffer, 0, byteBuffer.Length);
                    listText.Items.Add("Sent " + byteBuffer.Length + " bytes to server...");
                    int totalBytesRcvd = 0;
                    int bytesRcvd = 0;
                    while (totalBytesRcvd < byteBuffer.Length)
                    {
                        if ((bytesRcvd = netStream.Read(byteBuffer, totalBytesRcvd,
                        byteBuffer.Length - totalBytesRcvd)) == 0)
                        {
                            listText.Items.Add("Connection closed prematurely.");
                            break;
                        }
                        totalBytesRcvd += bytesRcvd;
                    }
                    listReceive.Items.Add("Received : " +
                        Encoding.ASCII.GetString(byteBuffer, 0, totalBytesRcvd));
                }
                catch (Exception exc)
                {
                    // listText.Items.Add(exc);
                }
                Thread.Sleep(1000);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int PORT_NO = Int32.Parse(txbServerPort.Text);
            string SERVER_IP = txbServerIp.Text;
            string textToSend = txbSend.Text;

            TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            listText.Items.Add("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}
