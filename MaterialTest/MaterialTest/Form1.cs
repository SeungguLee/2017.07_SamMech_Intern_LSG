using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MaterialTest
{
    public partial class Form1 : MaterialForm
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

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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
    }
}
