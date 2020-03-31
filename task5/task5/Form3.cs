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

namespace task5
{
    public partial class Form3 : Form
    {
        int CX = 0, CY = 0, CZ = 0;
        Graphics g;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Random random = new Random();
            Size size = new Size(20, 20);
            int countCircles = CX + CY + CZ;
            for (int i = 0; i < countCircles; i++)
            {
                Point loc = new Point(random.Next(size.Width, pictureBox1.Width - 2 * size.Width), random.Next(size.Height, pictureBox1.Height - 2 * size.Height));
                g.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(loc, size));
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int countCurvesBezie = CX + CY;
            g = e.Graphics;
            for (int i = 0; i < countCurvesBezie; i++)
            {
                int dist = 20 * i;
                Point p1 = new Point(dist, dist);
                Point p2 = new Point(pictureBox2.Width - dist, dist);
                Point p3 = new Point(dist, pictureBox2.Height - dist);
                Point p4 = new Point(pictureBox2.Width - dist, pictureBox2.Height - dist);
                g.DrawBezier(new Pen(new SolidBrush(Color.Aqua)), p1, p2, p3, p4);
            }
        }

        private void DrawCurves(int CX)
        {
            double step = 0.01, xmin = -10, xmax = 10;
            int count = (int)Math.Ceiling((xmax - xmin) / step);

            double[] x = new double[count];
            List<Series> y = new List<Series>();

            for (int i = 0; i < count; i++) x[i] = xmin + step * i;
            for (int i = 0; i < CX; i++)
            {
                y.Add(new Series());
                y[i].ChartType = SeriesChartType.Spline;
                for (int j = 0; j < count; j++)
                {
                    y[i].Points.AddXY(x[j], Math.Atan((i + 1) * x[j]));
                }
            }
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;

            for (int i = 0; i < CX; i++) chart1.Series.Add(y[i]);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            try
            {
                CX = Convert.ToInt32(textBoxX.Text);
                CY = Convert.ToInt32(textBoxY.Text);
                CZ = Convert.ToInt32(textBoxZ.Text);
                DrawCurves(CX);
            }
            catch
            {

            }
            finally
            {
                pictureBox2.Refresh();
                pictureBox1.Refresh();
            }
          
        }
    }
}
