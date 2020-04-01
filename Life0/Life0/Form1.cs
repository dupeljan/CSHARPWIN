using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life0
{
    public partial class Form1 : Form
    {
        Game game;
        Size entitySize = new Size(20, 20);

        // Inicializing form
        public Form1()
        {
            InitializeComponent();
            game = new Game(pictureBoxGameField, entitySize);
            game.initNewGame();
            
        }

        // Field paint handler
        private void pictureBoxGameField_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            foreach (var ent in game.GetEntities())
                g.FillEllipse(new SolidBrush(Game.colors[(int)ent.getGender()]), new Rectangle(ent.getPos(), game.getSize()));
            foreach(var meal in game.GetMeals())
                g.FillEllipse(new SolidBrush(Game.colors[2]), new Rectangle(meal,game.getSize()));

        }

        // Timer tick handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.makeStep();
            if (game.getState() == GameState.inProccess)
                pictureBoxGameField.Refresh();
            else if (game.getState() == GameState.end)
                MessageBox.Show("Game is ended!");
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            game.initNewGame();
        }
    }
}
