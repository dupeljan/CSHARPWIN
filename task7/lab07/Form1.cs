using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07 {
    public partial class Form1 : Form {
        private int width;
        private int height;
        private Color myColor;
        Point loc = new Point(50, 50);
        Rectangle r;

        public Form1() {
            InitializeComponent();
            myColor = Color.Red;
            width = 10;
            height = 10;
            r = new Rectangle(loc, new Size(width, height));
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics dc = e.Graphics;
            Pen myPen = new Pen(myColor);
            dc.DrawRectangle(myPen, r);
        }

        private void SmallToolStripMenuItem_Click(object sender, EventArgs e) {
            r.Size = new Size(10, 10);
            Invalidate();
        }

        private void BigToolStripMenuItem_Click(object sender, EventArgs e) {
            r.Size = new Size(100, 100);
            Invalidate();
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e) {
            myColor = Color.Red;
            Invalidate();
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e) {
            myColor = Color.Blue;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            Point myPoint = new Point(e.X, e.Y);
            if (e.Button.ToString() == "Right" && r.Contains(e.Location))
                contextMenuStrip1.Show(this, myPoint);
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e) {
            myColor = Color.Green;
            Invalidate();
        }

        private void MiddleToolStripMenuItem_Click(object sender, EventArgs e) {
            r.Size = new Size(50, 50);
            Invalidate();
        }
    }
}
