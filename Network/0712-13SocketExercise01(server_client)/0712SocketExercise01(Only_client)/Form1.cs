using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;
using System.IO;

namespace _0712SocketExercise01_server_client_
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string text_to_send;
        Boolean br1 = false;
        Boolean br2 = false;


        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); //get my own IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = address.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    textBox3.AppendText("Connected to Server" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();     // start receiving Data in background
                    backgroundWorker2.WorkerSupportsCancellation = false;  // Ability to cancel this thread
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //receive data
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    if (receive == "end")
                    {
                        this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Server out\n"); }));
                        backgroundWorker1.Dispose();
                        STW.Close();
                        STR.Close();
                        client.GetStream().Close();
                        client.Close();
                    }
                    this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Others : " + receive + "\n"); }));
                    receive = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) //send data
        {
            if (client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Me : " + text_to_send + "\n"); }));
                textBox3.AppendText("Me : " + text_to_send + "\n");
            }
            else
            {
                MessageBox.Show("Send failed!");
            }

            backgroundWorker2.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                text_to_send = textBox4.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox4.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    STW.WriteLine("end");
                    backgroundWorker1.Dispose();
                    STW.Close();
                    STR.Close();
                    client.GetStream().Close();
                    client.Close();
                    e.Cancel = false;
                }
            }
            catch { }
        }
    }
}