using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form8 : Form
    {
        Graphics g;
        Size size = new Size(50, 50);
        List<Point> locs = new List<Point>();
        Random random = new Random();

        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            foreach (Point p in locs)
            {
                g.FillEllipse(new SolidBrush(Color.HotPink), new Rectangle(p, size));
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                locs.Add(new Point(random.Next(size.Width, pictureBox1.Width - size.Width), random.Next(size.Height, pictureBox1.Height - size.Height)));
               
            }
            if (e.Button == MouseButtons.Left)
                if (locs.Count > 0)
                {
                    locs.RemoveAt(locs.Count - 1);
                   
                }
                else
                    MessageBox.Show("Все окружности уже удалены");

            pictureBox1.Refresh();
        }
    }   
}
