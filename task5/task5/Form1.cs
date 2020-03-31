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
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            var x = Coordx.Value;
            var y = CoordY.Value;
            var r = Radius.Value;
            var rect = new Rectangle(new Point((int)(x-r),(int)(y-r)), new Size((int)(2*r),(int)(2*r)));
            g.FillEllipse(new SolidBrush(Color.Red), rect);

        }
    }
}
