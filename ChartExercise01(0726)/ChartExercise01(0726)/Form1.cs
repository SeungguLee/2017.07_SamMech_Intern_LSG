using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Threading;

namespace ChartExercise01_0726_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            chart1.Series[0].Points.AddXY(1, 0);
            double axisMinimum = this.chart1.Series[0].Points[0].XValue;
            this.chart1.ChartAreas[0].AxisX.Minimum = axisMinimum;
            this.chart1.ChartAreas[0].AxisX.Maximum = axisMinimum + 19;
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;


            DispatcherTimer t = new DispatcherTimer();
            t.Interval = TimeSpan.FromMilliseconds(1000);
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();
            Series series = chart1.Series[0];
            series.Points.AddXY(series.Points[series.Points.Count - 1].XValue + 1, rand.Next(100));     //rand.Next(100)이 Y값.

            while (this.chart1.Series[0].Points.Count > 10)
            {
                series.Points.RemoveAt(0);
            }

            double axisMinimum = this.chart1.Series[0].Points[0].XValue;

            this.chart1.ChartAreas[0].AxisX.Minimum = axisMinimum;
            this.chart1.ChartAreas[0].AxisX.Maximum = axisMinimum + 9;

            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;

        }


    }
}
