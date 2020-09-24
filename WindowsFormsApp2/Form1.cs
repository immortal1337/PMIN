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


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int stepX = 0;
        int stepI = 0;
        string auf = "Авдой сасная тёлочка";

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += button1_Click;
            timer2.Tick += Step;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Step(object sender, EventArgs e)
        {
            stepX = rnd.Next(0, 10);
            stepI += 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double x = -10000 + stepI;
            double f = 50;
            const int N = 10000;
            //1 часть    
            for (int i = 10; i < N; i=i+1000)
                {
                double value = rnd.Next(-500,500) ;
                double y = Math.Cos(5 * i) * Math.Cos(f) + value/10000;
                    chart1.Series[0].Points.AddXY(x, y);
                    x = x + 10 + stepX; ;
                }
            for (int i = 10; i < N+ 10; i = i + 100)
            {
                double value = rnd.Next(-500, 500);
                double y = Math.Cos(5 * i) * Math.Cos(f) + value / 10000;
                chart1.Series[0].Points.AddXY(x, y);
                x = x + 50 + stepX; ;
            }
            // середина
            for (int i = 10; i < N + 100; i = i + 250)
            {
                double value = rnd.Next(-100, 100);
                double y = Math.Cos(5 * i+6 ) * Math.Cos(f) + value / 10000;
                chart1.Series[0].Points.AddXY(x, y + 5);
                x = x + 5 + stepX; ;
            }
            for (int i = 10; i < N+ 10; i = i + 100)
            {
                double value = rnd.Next(-100, 1000);
                double y = Math.Cos(5 * i) * Math.Cos(f) + value / 10000;
                chart1.Series[0].Points.AddXY(x, y);
                x = x + 50 + stepX; ;
            }
            //1 часть
            for (int i = 10000; i < N+ 10000; i += 10000)
            {
                double value = rnd.Next(-100, 100);
                double y = Math.Cos(5 * i) * Math.Cos(f) + value / 10000;
                chart1.Series[0].Points.AddXY(x, y);
                x += 100 + stepX; ;
            }

        }
    }
}
