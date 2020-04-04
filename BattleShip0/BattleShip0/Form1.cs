﻿using System;
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
    public enum ShotStatus
    {
        miss,
        hurt,
        kill,
        killEverybody

    }

    enum ProgramState
    {
        init = 0,
        game = 1,
        end  = 2
    }
    
    enum GameState
    {
        WaitPlayerChoise,
        WaitOtherPlayerStatus,
        WaitOtherPlayerPos
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
       

        ProgramState programState; // Program state
        GameState gameState; // Game state
        OtherPlayer otherPlayer; // Other player pointer
        Size fieldSize = new Size(10,10); // Fied size
       
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            setProgramState(ProgramState.end);
        }


        void setProgramState(ProgramState state)
        {
            
            if (state == ProgramState.init)
            {
                buttonChangeGameState.Text = "Begin battle!";
                setStatusLabel();



                // Init field
                fieldEnemy.Init(fieldSize, Player.enemy);
                fieldAlly.Init(fieldSize, Player.ally);


                // Init buttons for ship chosing
                GameInit.SetInitButtons(groupBoxInit,fieldAlly);

                programState = state;
            }
            else if (state == ProgramState.end)
            {
                buttonChangeGameState.Text = "Start";
                programState = state;
            }
            else if (state == ProgramState.game && ShipButton.GetShipsLeft() == 0)
            {
                buttonChangeGameState.Text = "Try again";
                gameState = GameState.WaitPlayerChoise;
                otherPlayer = new Bot(Level.easy, fieldEnemy,this);

                programState = state;
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
            if(programState == ProgramState.init)
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
                
                fieldAlly.MoveCurShip(direction);

                setStatusLabel();
            }

        }

        // Button reset handler
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (programState == ProgramState.init)
            {
                buttonChangeGameState.Text = "Begin battle!";
                setStatusLabel();


                // Reset ally field
                fieldAlly.Reset();

                // Init buttons for ship chosing
                GameInit.SetInitButtons(groupBoxInit, fieldAlly);
                ShipButton.active = false;
            }
        }

        private void buttonFillRandom_Click(object sender, EventArgs e)
        {
            fieldAlly.RandomPutShip();
        }

        private void buttonChangeGameState_Click(object sender, EventArgs e)
        {
            setProgramState((ProgramState)((( (int) programState) + 1) % 3));
        }

        // Game part

        void setGameState(GameState state)
        {
            gameState = state;
            if (state == GameState.WaitOtherPlayerPos)
                otherPlayer.SendPos();

            
        }
        public void SendPos(Point pos)
        {
            if (gameState == GameState.WaitPlayerChoise)
            {
                setGameState(GameState.WaitOtherPlayerStatus);
                otherPlayer.RecevePos(pos);
                
            }
        }

        public void ReceveStatus(ShotStatus shotStatus)
        {
            if(gameState == GameState.WaitOtherPlayerStatus)
            {
                // handle shot status here
                MessageBox.Show(shotStatus.ToString());
                if (shotStatus == ShotStatus.miss)
                    setGameState(GameState.WaitOtherPlayerPos);
                else if (shotStatus == ShotStatus.killEverybody)
                {
                    MessageBox.Show("You win!");
                    setProgramState( ProgramState.end);
                }
                    
                else
                    setGameState(GameState.WaitPlayerChoise);
            }
        }

        public void RecevePos(Point pos)
        {
            if(gameState == GameState.WaitOtherPlayerPos)
            {
                // Handl pos here
                // compute status
                var status = fieldAlly.Shot(pos);
                otherPlayer.ReceveStatus(status);
                if (status == ShotStatus.miss)
                    setGameState(GameState.WaitPlayerChoise);
                else if (status == ShotStatus.killEverybody)
                {
                    MessageBox.Show("You lose!");
                    setProgramState(ProgramState.end);
                }
                 else
                    setGameState(GameState.WaitOtherPlayerPos);
            }
        }
    }
}
