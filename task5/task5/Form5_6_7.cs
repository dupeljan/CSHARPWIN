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
    public partial class Form5_6_7 : Form
    {
        Point loc, drawLoc;
        Graphics g;
        Size size = new Size(50, 50);
        int planeY, planeX;
        bool mirror = false;
        bool initMirror = false;
        int step = 5;
        public Form5_6_7()
        {
            InitializeComponent();
           
            loc = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2); ;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            loc = new Point(e.Location.X - size.Width / 2, e.Location.Y - size.Height / 2);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if (mirror)
            {
                if (!initMirror)
                {
                    planeX = loc.X;
                    planeY = loc.Y;
                    initMirror = true;
                }


                drawLoc.Y = 2 * planeY - loc.Y;
                drawLoc.X = 2 * planeX - loc.X;
            }
            else
                drawLoc = loc;
            g.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(drawLoc, size));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            loc = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            pictureBox1.Refresh();
        }

        private void Form5cs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) loc.X -= step;
            if (e.KeyCode == Keys.Right) loc.X += step;
            if (e.KeyCode == Keys.Down) loc.Y += step;
            if (e.KeyCode == Keys.Up) loc.Y -= step;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mirror = !mirror;
            initMirror = false;
        
        }
    }
}
