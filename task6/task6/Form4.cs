using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6
{
    public partial class Form4 : Form
    {
        Graphics g;
        Size size;
        Point loc;
        int delta = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            size = new Size(Width / 5, Height / 8);
            loc = new Point((Width - size.Width) / 2, (Height - size.Height) / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loc.X < 0 || size.Height < 10)
                delta = -delta;
            loc = new Point(loc.X - 3 * delta, loc.Y - 2 * delta);
            size = new Size(size.Width + 6 * delta, size.Height + 4 * delta);
            Refresh();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(Brushes.Red, new Rectangle(loc, size));
            
        }


    }
}
