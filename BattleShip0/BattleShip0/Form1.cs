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
        end = 2
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
            gameState = state;
            if ( gameState == GameState.init)
            {
                buttonChangeGameState.Text = "Begin battle!";
                // Init buttons for ship chosing
                

                // Init field
                enemyField = new Field(groupBoxEnemy, fieldSize,Player.enemy);
                allyField = new Field(groupBoxAlly, fieldSize, Player.ally);

                GameInit.SetInitButtons(groupBoxInit,allyField);

            }
            else if (gameState == GameState.end)
            {
                buttonChangeGameState.Text = "Start";
            }
            else if (gameState == GameState.game)
            {
                buttonChangeGameState.Text = "Try again";
            }

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
            }
                
        }

     
        private void buttonChangeGameState_Click(object sender, EventArgs e)
        {
            setGameState((GameState)((( (int) gameState) + 1) % 3));
        }
    }
}
