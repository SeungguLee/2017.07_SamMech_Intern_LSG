using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace CSLogMakerVo1
{
    public partial class Form1 : Form
    {
        int count = 0;  //Log 추가 카운트
        string[] lines = null;
        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);
        [DllImport("kernel32.dll")]
        static extern uint GetTickCount();

        [DllImport("Log.dll")]
        static extern short SetFileName(short nFileNo, string sFile, string ExtensiionName);
        // 리스트 박스 시간 옵션 ( 1: YYYY-MM-DD HH:MM:SS , 2:없음, 3: HH:MM:SS)
        [DllImport("Log.dll")]
        static extern short SetFileNameAddList(short nFileNo, string sFile, string ExtensiionName, short nType, IntPtr ListHandle);
        [DllImport("Log.dll")]
        static extern short MessagePushing(short nFileNo, string sLog);
        [DllImport("Log.dll")]
        static extern short SetDeleteFileList(int lTime, string sFilter, string sDir);
        [DllImport("Log.dll")]
        static extern short StartFileDelete();
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeDir(string sPath)
        {
            DirectoryInfo di = new DirectoryInfo(sPath);
            if (di.Exists == false)
                di.Create();
        }
        public void LogStart()
        {
            string s;
            MakeDir("C:\\Test" + "\\Log");
            MakeDir("C:\\Test" + "\\Log\\Trace Log");

            SetFileNameAddList(0, "C:\\Test" + "\\Log\\Trace Log\\Trace log", "Log", 1, listBox1.Handle);
            Sleep(100);
            s = " SW Ver. " + "1.1.1";
            MessagePushing(0, ",Program Start" + s);
            count++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessagePushing(0, textBox1.Text);
            count++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox 클리어
            listBox1.Items.Clear();

            //폴더는 남겨두고, 그 안의 파일들만 삭제
            string[] dirs = Directory.GetFiles(@"c:\Test\Log\Trace Log");
            foreach (var dir in dirs)
            {
                File.Delete(dir);
            }

            //폴더와 하위파일들 모두 삭제
            //Directory.Delete(@"C:\Test\Log\Trace Log", true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //이전 버튼(최신데이터 한 개 삭제)
            //MessageBox.Show(Convert.ToString(count-1));
            listBox1.SelectedItems.Remove(listBox1.SelectedItem);
            listBox1.Refresh();


        }


    }
}
