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
        bool pause = false;
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
            foreach (var meal in game.GetMeals())
                g.FillEllipse(new SolidBrush(Game.colors[2]), new Rectangle(meal, game.getSize()));
        }

        // Timer tick handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.makeStep();
            if (game.getState() == GameState.inProccess)
                pictureBoxGameField.Refresh();
            else if (game.getState() == GameState.end)
                MessageBox.Show("Game is ended!");
            var statistic = game.getStatistic();
            labelAlive.Text = statistic.alive.ToString();
            labelDied.Text = statistic.died.ToString();
            labelFood.Text = statistic.eatenMeals.ToString();
            labelSteps.Text = statistic.step.ToString();
            labelEntitySum.Text = (statistic.alive + statistic.died).ToString();

        }

        // Init new game
        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            game.initNewGame();
        }

        // Pause timer
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (pause)
                timer1.Start();
            else
                timer1.Stop();
            pause = !pause;
        }
    }
}
