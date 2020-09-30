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
        double x1 = -10000;
        double x2 = 10000;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += button1_Click;
            
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-6, 6);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(-7000, 7000);


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
            
                timer1.Enabled = !timer1.Enabled;

                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                double f = 50;


                int rnd_step = rnd.Next(0, 4);
                for (int x = -10000; x < -5000; x = x + 10)
                {
                    double value = rnd.Next(-100, 700);
                    double y = Math.Cos(5 * x) * Math.Cos(f) + value / 1000;
                    chart1.Series[0].Points.AddXY(x, y);
                }
                for (int x = -5000; x < 0; x = x + 10)
                {
                    double value = rnd.Next(-500, 800);
                    double y = Math.Cos(5 * x) * Math.Cos(f) + value / 1000;

                    if (rnd_step == 2 || rnd_step == 4)
                    {
                        int randx = rnd.Next(-5000, 0);
                        for(int i = randx; i < randx+100; i+=50)
                        {
                        for (int h = 0; h < 60; h += 10)
                        {
                            chart1.Series[0].Points.AddXY(x = x + h, rnd.Next((int)y, (int)y +5)); // надо додумать рандомное появление красивой синусоиды в промежутке с -5000 до 0 
                        }
                        }

                    rnd_step = rnd.Next(1, 4);
                }
                    else
                    {

                        chart1.Series[0].Points.AddXY(x, y);
                    }
                    

                }


            for (int x = 0; x < 5000 ; x = x + 10)
            {
                double value = rnd.Next(-100, 900);
                double y = Math.Cos(5 * x) * Math.Cos(f) + value / 1000;
                chart1.Series[0].Points.AddXY(x, y);
            }

            for (int x = 5000; x <10000; x += 10)
            {
                double value = rnd.Next(-1000, 1000);
                double y = Math.Cos(5 * x) * Math.Cos(f) + value / 1000;
                chart1.Series[0].Points.AddXY(x, y);


            }
            

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


    }
}
