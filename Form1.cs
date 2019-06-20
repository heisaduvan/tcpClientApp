using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_IP_Client
{
    public partial class Form1 : Form
    {
        string serverIP;
        int port ;
        TcpClient client;
        NetworkStream streamObject;
        ASCIIEncoding sendData;
        Thread communicationController;
        Thread receiveMessage;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void commControl()
        {
            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(50);
                    if (streamObject.CanWrite)
                        successCase();
                    else
                    {
                        errorCase();
                        btnConnect.PerformClick();
                    }
                }
            }
            catch (System.IO.IOException ex)
            {
                errorCase();
                client.Dispose();
                communicationController.Abort();
                reConnectMethod();
            }
        }
        private void receiveMessageMethod()
        {
            try
            {
                while(true)
                {
                    byte[] receiveData = new byte[100];
                    streamObject.ReadTimeout = 10000;
                    streamObject.Read(receiveData, 0, 100);
                    string result = System.Text.Encoding.UTF8.GetString(receiveData);
                    txtMessage.Text = result;
                }
            }
            catch
            {
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serverIP = txtIP.Text;
                port=Convert.ToInt16(txtPort.Text);
                client = new TcpClient();
                client.Connect(serverIP, port);
                streamObject = client.GetStream();
                streamObject.WriteTimeout = 100;
                sendData = new ASCIIEncoding();
                communicationController = new Thread(commControl);
                receiveMessage = new Thread(receiveMessageMethod);
                communicationController.Start();
                receiveMessage.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"Belirtilen adreste bir server açık değil gibi duruyor. Gerekli kontrolleri yaptıktan sonra yeniden deneyin.");
            }
        }
        private void successCase()
        {
            btnStatus.BackColor = Color.Green;
            labelStatus.Text = "Connection success..";
            labelStatus.BackColor = Color.Green;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }
        private void errorCase()
        {
            btnStatus.BackColor = Color.Red;
            labelStatus.Text = "Connection error..";
            labelStatus.BackColor = Color.Red;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            reConnectMethod();
        }
        private void reConnectMethod()
        {
            try
            {
                serverIP = txtIP.Text;
                port = Convert.ToInt16(txtPort.Text);
                client = new TcpClient();
                client.Connect(serverIP, port);
                streamObject = client.GetStream();
                streamObject.WriteTimeout = 100;
                sendData = new ASCIIEncoding();
                labelStatus.Text = "Trying to reconnect..";
                communicationController = new Thread(commControl);
                communicationController.Start();
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show("Belirtilen adreste bir server artık açık değil gibi duruyor. Gerekli kontrolleri yaptıktan sonra yeniden deneyin.");
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            communicationController.Abort();
            client.Dispose();
            btnConnect.Enabled = true;
            errorCase();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data = sendData.GetBytes(txtMessage.Text);
            streamObject.Write(data, 0, data.Length);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(communicationController!=null)
                communicationController.Abort();
        }
    }
}
