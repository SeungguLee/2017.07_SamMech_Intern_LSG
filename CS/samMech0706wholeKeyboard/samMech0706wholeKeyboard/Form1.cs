using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samMech0706wholeKeyboard
{
    public partial class Form1 : Form
    {
        Boolean SLettercase = false; // shift로 대문자 사용
        Boolean CLettercase = false; // CapsLock으로 대문자 사용
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonLShift_Click(object sender, EventArgs e)
        {
            SLettercase = true;
        }

        private void buttonCLock_Click(object sender, EventArgs e)
        {
            CLettercase = !CLettercase;
        }

        private void buttonVbar_Click(object sender, EventArgs e)
        {
            if (SLettercase || CLettercase)
            {
                textBox1.Text += (((Button)sender).Text);
                SLettercase = false;
            }

            else
                textBox1.Text += (((Button)sender).Text).ToLower();

        }

        private void buttonBSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n";
        }

    }
}
