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
        string[] numarr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        string[] hexdecarr = { "Hexa", "Decimal", "String" };
        string receivestr;
        string sendstr;
        int length;
        int namenum;
        string firstname;
        string[] namearr = new string[2048];
        string[] hexarr = new string[2048];
        string[] decarr = new string[2048];
        int dnumber;
        int stringnum;
        string sendmsg;


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
            comboBox1.Items.AddRange(numarr);
            comboBox2.Items.AddRange(hexdecarr);
        }

        private void button1_Click(object sender, EventArgs e)      //connect
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
                    this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("\nOthers : " + receivestr + "\n"); }));


                    if (receivestr.Substring(18, 4) == "0000")        //종료코드가 0000이 아닐때는 예외.
                    {
                        _sdata.Initialize();
                        this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("\n쓰기를 완료하였습니다.\n"); }));

                    }
                    else
                    {
                        MessageBox.Show("종료코드 에러 발생");
                        _sdata.Initialize();
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
                this.textBox3.Invoke(new MethodInvoker(delegate() { textBox3.AppendText("\nMe : " + sendstr + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed!");
            }

            _data.Initialize();

            backgroundWorker2.CancelAsync();
        }




        private void button3_Click(object sender, EventArgs e)              //Setting Button
        {
            if (textBox4.Text == "" || comboBox1.SelectedItem.ToString() == "" || comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("세가지의 값을 모두 입력하여야 합니다.");
            }
            else
            {
                button2.PerformClick();
                firstname = textBox4.Text;                                      //시작 디바이스의 값
                namenum = Int32.Parse(firstname.Substring(1));                  //시작 디바이스의 숫자값
                dnumber = Int32.Parse(comboBox1.SelectedItem.ToString());       //디바이스 갯수

                for (int i = 0; i < 10 && i < dnumber; i++)                    //Address 내용을 textbox에 입력
                {
                    TextBox target = (Controls.Find("text_n" + i.ToString(), true)[0] as TextBox);
                    target.Text = firstname.Substring(0, 1) + namenum;
                    namenum++;

                }


                if (comboBox2.SelectedItem.ToString() == "Hexa")            //입력 Type이 헥사일 경우 decimal을 ReadOnly로 변경.
                {
                    for (int i = 0; i < 10; i++)
                    {
                        TextBox target = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                        target.ReadOnly = true;
                        TextBox target1 = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                        target1.ReadOnly = false;

                    }
                    for (int i = dnumber; i < 10; i++)
                    {
                        TextBox target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                        target.ReadOnly = true;
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Decimal")                                                     //입력 type이 decimal 경우 hexa를 ReadOnly로 변경.
                {
                    for (int i = 0; i < 10; i++)
                    {
                        TextBox target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                        target.ReadOnly = true;
                        TextBox target1 = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                        target1.ReadOnly = false;

                    }
                    for (int i = dnumber; i < 10; i++)
                    {
                        TextBox target = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                        target.ReadOnly = true;
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "String")
                {

                }
            }
        }


        private void button4_Click(object sender, EventArgs e)          //send Button
        {
            string strdnumber = "";
            Boolean fulldata = true;
            if (dnumber == 10)
                strdnumber = "0A";
            else
                strdnumber = "0" + dnumber.ToString();
            sendmsg = "500000FF03FF00" + (24 + 4 * dnumber).ToString("X4") + "001014010000" + firstname.Substring(0, 1) + "*00" + firstname.Substring(1) + "00" + strdnumber;


            if (comboBox2.SelectedItem.ToString() == "Hexa")     //헥사로 값을 입력 받을 때
                for (int i = 0; i < dnumber; i++)
                {
                    TextBox target = (Controls.Find("text_h" + i.ToString(), true)[0] as TextBox);
                    if (target.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력하세요.");
                        fulldata = false;
                        break;
                    }
                    else
                    {
                        sendmsg += target.Text;
                    }
                }
            else
                for (int i = 0; i < dnumber; i++)
                {
                    TextBox target = (Controls.Find("text_d" + i.ToString(), true)[0] as TextBox);
                    if (target.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력하세요.");
                        fulldata = false;
                        break;
                    }
                    else
                    {
                        int buf = Int32.Parse(target.Text);
                        sendmsg += buf.ToString("X4");
                    }

                }
            if (fulldata == true)
            {
                MessageBox.Show(sendmsg);
                _data = Encoding.Default.GetBytes(sendmsg);
                backgroundWorker2.RunWorkerAsync();
            }
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

        private void button2_Click(object sender, EventArgs e)
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
        }

        private void button5_Click(object sender, EventArgs e)  //String, 선두 디바이스만으로 쓰기 버튼
        {
            string buf;
            string[] stringarr = new string[2048];
            string sendstringdata;


            buf = textBox5.Text;
            char[] values = buf.ToCharArray();
            stringnum = values.Length;          //string data의 글자 수

            if (stringnum % 2 == 0)                             //보낼 String의 문자수가 짝수일 때
            {
                int bufint;
                for (int i = 0; i < stringnum; i += 2)
                {
                    bufint = Convert.ToInt32(values[i + 1]);
                    stringarr[i] = bufint.ToString("X2");
                    bufint = Convert.ToInt32(values[i]);
                    stringarr[i + 1] = bufint.ToString("X2");
                }
            }


            else                                               //보낼 String의 문자수가 홀수일 때
            {
                int bufint;
                for (int i = 0; i < stringnum ; i += 2)
                {
                    if (i == stringnum - 1)     //마지막일 때
                    {
                        stringarr[i] = "00";
                        bufint = Convert.ToInt32(values[i]);
                        stringarr[i + 1] = bufint.ToString("X2");
                    }
                    else
                    {
                        bufint = Convert.ToInt32(values[i + 1]);
                        stringarr[i] = bufint.ToString("X2");
                        bufint = Convert.ToInt32(values[i]);
                        stringarr[i + 1] = bufint.ToString("X2");
                    }
                }
                stringnum++;
            }
            sendstringdata = "500000FF03FF00" + (24 + 2 * stringnum).ToString("X4") + "001014010000" + textBox4.Text.Substring(0, 1) + "*00" + textBox4.Text.Substring(1) + (stringnum / 2).ToString("X4");
            for (int i = 0; i < stringnum; i++)
            {
                sendstringdata += stringarr[i];
            }
            _data = Encoding.Default.GetBytes(sendstringdata);
            backgroundWorker2.RunWorkerAsync();


        }


    }
}