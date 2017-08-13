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

        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Byte[] _data = new Byte[2048];
        Byte[] _sdata = new Byte[2048];
        string receivestr;
        string sendstr;
        int length;
        string[] namearr = new string[2048];
        string[] hexarr = new string[2048];
        string[] decarr = new string[2048];
        string[] sizearr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };


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
            cbox_size.Items.AddRange(sizearr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
            try
            {
                client.Connect(ipep);
                MessageBox.Show("Socket Connected");
                if (client.Connected)
                {
                    textBox3.AppendText("Connected to Server" + "\n");

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
                    client.Receive(_sdata);
                    receivestr = Encoding.Default.GetString(_sdata);
                    this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Others : " + receivestr + "\n"); }));


                    if (receivestr.Substring(18, 4) == "0000")        //종료코드가 0000이 아닐때는 예외.
                    {
                        length = Convert.ToInt32(receivestr.Substring(14, 4), 16) - 4;    //순수 데이터의 길이.
                        int j = 22;
                        int namenum = Int32.Parse(sendstr.Substring(34, 4));
                        for (int i = 0; i < 10 && i < length / 4; i++)    //값들을 각각의 배열에 넣어준다. textbox가 10개 이므로, 10번 이상은 돌리지 않는다.
                        {
                            namearr[i] = sendstr.Substring(30, 1) + namenum.ToString();
                            hexarr[i] = receivestr.Substring(j, 4);
                            decarr[i] = Convert.ToInt32(hexarr[i], 16).ToString();
                            namenum++;
                            j += 4;
                        }

                        for (int i = 0; i < length / 4 && i < 10; i++)
                        {
                            TextBox target = (Controls.Find("text_n" + i.ToString(), true)[0] as TextBox);
                            target.Text = namearr[i];

                            target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                            target.Text = hexarr[i];

                            target = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                            target.Text = decarr[i];

                        }
                        receivestr = "";

                    }
                    else
                    {
                        MessageBox.Show("종료코드 에러 발생");
                    }



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
                client.Send(_data);
                sendstr = Encoding.Default.GetString(_data);
                this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("Me : " + sendstr + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed!");
            }

            backgroundWorker2.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)              //send Button
        {
            for (int i = 0; i < 10; i++)                                    //textbox 내용 초기화
            {
                TextBox target = (Controls.Find("text_n" + i.ToString(), true)[0] as TextBox);
                target.Text = "";

                target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                target.Text = "";

                target = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                target.Text = "";

            }
            _data = Encoding.Default.GetBytes(textBox4.Text);
            backgroundWorker2.RunWorkerAsync();

            textBox4.Text = "";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   //종료 버튼을 눌렀을 때
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    backgroundWorker1.Dispose();
                    client.Close();
                    e.Cancel = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btn_readset_Click(object sender, EventArgs e)
        {
            int dnumber;
            string sendmsg;
            string firstname;
            string strdnumber;
            firstname = tbox_first.Text;
            dnumber = Int32.Parse(cbox_size.SelectedItem.ToString());
            if(dnumber == 10)
                strdnumber = "0A";
            else
                strdnumber = "0" + dnumber.ToString();

            sendmsg = "500000FF03FF00" + "0018" + "001004010000" + firstname.Substring(0, 1) + "*00" + firstname.Substring(1) + "00" + strdnumber;
            textBox4.Text = sendmsg;
        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            int dnumber = Int32.Parse(cbox_size.SelectedItem.ToString());
            string hexstring = "";
            for (int i = 0; i < dnumber; i++)
            {
                TextBox target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                hexstring += target.Text;
            }
            StringBuilder sb = new StringBuilder();



            for (int i = 0; i < hexstring.Length; i += 4)   //거꾸로 읽어 주어야 한다.
            {
                sb.Append(Convert.ToChar(Convert.ToUInt32(hexstring.Substring(i+2, 2), 16)));

                sb.Append(Convert.ToChar(Convert.ToUInt32(hexstring.Substring(i,2), 16)));
            }
            tbox_translate.Text = sb.ToString();
        }
    }
}