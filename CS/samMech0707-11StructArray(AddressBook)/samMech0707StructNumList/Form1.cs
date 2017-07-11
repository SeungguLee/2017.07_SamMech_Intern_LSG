using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samMech0707StructNumList
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct NumList                   //구조체 선언
        {
            public string name;
            public string company;
            public string phoneNum;
        }

        NumList[] numArr = new NumList[100];    //구조체형 배열 선언



        private void button1_Click(object sender, EventArgs e)  //ADD button Event
        {
            if (textBox1.Text == "")                            //name항목이 없을 경우
                MessageBox.Show("Must have Name");
            else
            {
                int edIndex = listBox1.Items.Count;
                numArr[edIndex].name = textBox1.Text;
                numArr[edIndex].company = textBox2.Text;
                numArr[edIndex].phoneNum = textBox3.Text;
                listBox1.Items.Add(numArr[edIndex].name);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) //listbox 항목 더블클릭 Event
        {
            int index = this.listBox1.IndexFromPoint(e.Location);               //더블클릭 시 선택되어있는 listbox의 항목 index.
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                textBox1.Text = numArr[index].name;
                textBox2.Text = numArr[index].company;
                textBox3.Text = numArr[index].phoneNum;
            }
        }

        private void button2_Click(object sender, EventArgs e)  //DELETE button Event
        {
            int ss = this.listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            //for (int i = ss; numArr[i + 1].name != null; i++) //스스로 짰던 V1
            //{
            //    numArr[i] = numArr[i + 1];
            //    numArr[i + 1].name = null;
            //}

            NumList[] numArr2 = new NumList[100];           //Array를 사용한 V2
            Array.Copy(numArr, numArr2, ss);
            Array.Copy(numArr, ss + 1, numArr2, ss, 99 - ss);
            numArr = numArr2;


        }
    }
}
