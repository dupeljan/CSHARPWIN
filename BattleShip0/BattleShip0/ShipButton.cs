using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0 
{
    enum InitButtonState
    {
        notSelected,
        selected,
        done
    }
    class ShipButton : Button
    {
        static bool active = false;  // Block other ShipButton if active

        int sHeight = 50;
        int sWidth = 120;
        InitButtonState state; // button state 
        public int count; // Count of sheeps left
        Point curPos; // Pos of current Ship
        bool curRotated; // Rotation of current ship
        public Ship ship;
        Field field;
        public ShipButton(Ship ship,Point buttonShift,int i,Field field) : base()
        {
            Text = ship.name + " " + ship.count.ToString();
            Height = sHeight;
            Width = sWidth;
            Location = new Point(buttonShift.X, buttonShift.Y + i * (int)(Height * (1.05)));
            Visible = true;
            this.ship = ship;
            this.field = field;
            state = InitButtonState.notSelected;
        }

        protected override void OnClick(EventArgs e)
        {
            if( !active)
            {
                //  block other ShipButtons 
                active = true;

                if (state == InitButtonState.notSelected)
                {
                    curPos = new Point(0, 0);
                    curRotated = true;
                    // Put ship on the field
                    field.PutShip(curPos, curRotated, ship.length);
                }
                                
               
            }
        }

    }
}
