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
        public TcpListener listener;
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
            listener = new TcpListener(IPAddress.Any, int.Parse(textBox2.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();     // start receiving Data in background
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //receive data
        {
            if (br1 == true)
                e.Cancel = true;
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    if (receive == "end")
                    {
                        this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Client out\n"); }));
                        backgroundWorker1.Dispose();
                        client.GetStream().Close();
                        client.Close();
                        STW.Close();
                        STR.Close();
                        listener.Stop();
                    }
                    else
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
            if (br2 == true)
                e.Cancel = true;
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
                    client.GetStream().Close();
                    MessageBox.Show("a");
                    client.Close();
                    MessageBox.Show("b");
                    listener.Stop();
                    e.Cancel = false;

                }
            }
            catch { }


        }
    }
}
