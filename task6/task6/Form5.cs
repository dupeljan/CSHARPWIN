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
    public partial class Form5 : Form
    {
        Graphics g;
        Rectangle r1, r2, GeneralRect, IntersectionRect;
        Size size = new Size(160, 120);
        int relocX, relocY;

   
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(Brushes.Red, r1);
            g.FillRectangle(Brushes.Blue, r2);
            g.DrawRectangle(Pens.Gray, GeneralRect);
            g.DrawRectangle(Pens.Pink, IntersectionRect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r1.Top > 10)
                r1.Location = new Point(r1.X - relocX, r1.Y - relocY);
            if (r2.Bottom < ClientRectangle.Height - 10)
                r2.Location = new Point(r2.X + relocX, r2.Y + relocY);
            GeneralRect.Location = r1.Location;
            GeneralRect.Size = new Size(r2.Right - r1.X, r2.Bottom - r1.Y);
            IntersectionRect.Location = r2.Location;
            IntersectionRect.Size = new Size(r1.Right - r2.X, r1.Bottom - r2.Y);
            Refresh();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            GeneralRect = IntersectionRect = r1 = r2 = new Rectangle(new Point((ClientRectangle.Width - size.Width) / 2, (ClientRectangle.Height - size.Height) / 2), size);
            relocX = ClientRectangle.Width / 60;
            relocY = ClientRectangle.Height / 60;
        }
    }
}
