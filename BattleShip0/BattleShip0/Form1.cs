using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0
{
    enum GameState
    {
        init = 0,
        game = 1,
        end  = 2
    }
    
    enum InitState
    {
        notSelected,
        selected
    }
    enum Player
    {
        ally,
        enemy
    }

    public partial class Form1 : Form
    {
       

        GameState gameState; // Game state
        Size fieldSize = new Size(10,10); // Fied size
        Field enemyField, allyField; // Fields  instances
       
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            setGameState(GameState.end);
        }


        void setGameState(GameState state)
        {
            
            if (state == GameState.init)
            {
                buttonChangeGameState.Text = "Begin battle!";
                setStatusLabel();
                
                

                // Init field
                enemyField = new Field(groupBoxEnemy, fieldSize,Player.enemy);
                allyField = new Field(groupBoxAlly, fieldSize, Player.ally);

                // Init buttons for ship chosing
                GameInit.SetInitButtons(groupBoxInit,allyField);

                gameState = state;
            }
            else if (state == GameState.end)
            {
                buttonChangeGameState.Text = "Start";
                gameState = state;
            }
            else if (state == GameState.game && ShipButton.GetShipsLeft() == 0)
            {
                buttonChangeGameState.Text = "Try again";
                gameState = state;
            }

        }

        public void setStatusLabel()
        {
            if (ShipButton.active)
                labelStatus.Text = "Put ship on the field";
            else
                labelStatus.Text = "Choose ship";
        }
        // Send pressed keys to ally field
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(gameState == GameState.init)
            {
               // MessageBox.Show(e.KeyChar.ToString());
                Direction direction;
                switch (e.KeyChar.ToString())
                {
                    case "w":
                        direction = Direction.up;
                        break;
                    case "a":
                        direction = Direction.left;
                        break;
                    case "s":
                        direction = Direction.down;
                        break;
                    case "d":
                        direction = Direction.right;
                        break;
                    case "r":
                        direction = Direction.rotate;
                        break;
                    case "p":
                        direction = Direction.commit;
                        break;
                    default:
                        return;
                }
                
                allyField.MoveCurShip(direction);

                setStatusLabel();
            }

        }

        // Button reset handler
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (gameState == GameState.init)
            {
                buttonChangeGameState.Text = "Begin battle!";
                setStatusLabel();

                // Init ally field
                allyField = new Field(groupBoxAlly, fieldSize, Player.ally);

                // Init buttons for ship chosing
                GameInit.SetInitButtons(groupBoxInit, allyField);

            }
        }

        private void buttonFillRandom_Click(object sender, EventArgs e)
        {
            allyField.RandomPutShip();
        }

        private void buttonChangeGameState_Click(object sender, EventArgs e)
        {
            setGameState((GameState)((( (int) gameState) + 1) % 3));
        }
    }
}
