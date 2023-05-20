using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //private TcpListener server;
        //private TcpClient client;
        //private NetworkStream stream;
        //private Thread receiveThread;
        //private bool connected;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    connected = false;
        //}

        //private void StartServerButton_Click(object sender, EventArgs e)
        //{
        //    int port = int.Parse(PortTextBox.Text);
        //    server = new TcpListener(IPAddress.Any, port);
        ////    server.Start();
        //    LogTextBox.AppendText("Server started. Waiting for client connection...\n");

        //    client = server.AcceptTcpClient();
        //    stream = client.GetStream();
        //    connected = true;

        //    receiveThread = new Thread(ReceiveMessages);
        //    receiveThread.Start();
        //}

        //private void ConnectButton_Click(object sender, EventArgs e)
        //{
        //    string serverIp = ServerIPTextBox.Text;
        //    int port = int.Parse(PortTextBox.Text);

        //    client = new TcpClient();
        //    client.Connect(serverIp, port);
        //    stream = client.GetStream();
        //    connected = true;

        //    receiveThread = new Thread(ReceiveMessages);
        //    receiveThread.Start();
        //}

        //private void SendButton_Click(object sender, EventArgs e)
        //{
        //    string message = MessageTextBox.Text;
        //    SendMessage(message);
        //}

        //private void ReceiveMessages()
        //{
        //    byte[] buffer = new byte[1024];
        //    string message = "";

        //    while (connected)
        //    {
        //        try
        //        {
        //            int bytesRead = stream.Read(buffer, 0, buffer.Length);
        //            message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        //            AppendMessageToLog(message);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred: " + ex.Message);
        //            connected = false;
        //        }
        //    }
        //}

        //private void SendMessage(string message)
        //{
        //    if (connected)
        //    {
        //        byte[] buffer = Encoding.ASCII.GetBytes(message);

        //        try
        //        {
        //            stream.Write(buffer, 0, buffer.Length);
        //            AppendMessageToLog("Me: " + message);
        //            MessageTextBox.Clear();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred: " + ex.Message);
        //            connected = false;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("You are not connected to a server or client.");
        //    }
        //}

        //private void AppendMessageToLog(string message)
        //{
        //    if (LogTextBox.InvokeRequired)
        //    {
        //        LogTextBox.Invoke(new Action<string>(AppendMessageToLog), message);
        //    }
        //    else
        //    {
        //        LogTextBox.AppendText(message + "\n");
        //    }
        //}

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    connected = false;

        //    if (receiveThread != null && receiveThread.IsAlive)
        //        receiveThread.Join();

        //    if (stream != null)
        //        stream.Close();

        //    if (client != null)
        //        client.Close();

        //    if (server != null)
        //        server.Stop();
        //}
    }
}
