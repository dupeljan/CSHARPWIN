using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace task5
{
    public partial class Form2_4 : Form
    {
        double fi = 0.0;
        double deltaFi = 0.05;
        const double Pi = 3.141592;
        int radius = 10;
        int deltaR = 1;
        int rMax = 60, rMin = 10; 
        Color color;
        bool timerRotateState = true;
        bool timerScaleState = true;
        public Form2_4()
        {
            InitializeComponent();
            color = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            try
            {
                var r = Math.Min(Convert.ToInt32(textBoxR.Text) , 255);
                var g = Math.Min(Convert.ToInt32(textBoxG.Text) , 255);
                var b = Math.Min(Convert.ToInt32(textBoxB.Text) , 255);
                color = Color.FromArgb(r, g, b);
            }
            catch
            {

            }
     
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fi += deltaFi;
            while (Math.Abs(fi) > 360.0)
                fi -= Math.Sign(fi) * 360.0;
            pictureBox1.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var h = pictureBox1.Height;
            var w = pictureBox1.Width;
            var r = (int) Math.Sqrt( Math.Pow(h,2) +Math.Pow(w,2)) / 8;
            
            var rect = new Rectangle(new Point( w/2 + (int)(r*Math.Cos(fi)), h/2 + (int) (r*Math.Sin(fi))), new Size((2 * radius), (2 * radius)));
            g.FillEllipse(new SolidBrush(color), rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timerRotateState)
                timerRotate.Stop();
            else
            {
                timerRotate.Start();
                deltaFi = -deltaFi;
            }
            timerRotateState = !timerRotateState;
        }

        private void buttonBoost_Click(object sender, EventArgs e)
        {
            if (timerScaleState)
                timerBoost.Stop();
            else
                timerBoost.Start();
            timerScaleState = !timerScaleState;
        }

        private void timerBoost_Tick(object sender, EventArgs e)
        {
            radius += deltaR;
            if (radius > rMax || radius < rMin)
                deltaR = -deltaR;
            pictureBox1.Refresh();  
        }
    }
}
