using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0 
{

    class ShipButton : Button
    {
        // Static part 

        public static bool active = false;  // Block other ShipButton if active
        static int shipLeft = 0;            // Total sheeps count

        public static int GetShipsLeft()
        {
            return shipLeft;
        }

        public static void decreseShipLeft()
        {
            shipLeft -= 1;
        }

        public static void ResetShipLeftToZero()
        {
            shipLeft = 0;
        }
        // Dynamic part
        int sHeight = 50;
        int sWidth = 120;
        public int count; // Count of sheeps left
        public Ship ship;
        Field field;
        public ShipButton(Ship ship,Point buttonShift,int i,Field field) : base()
        {
            Height = sHeight;
            Width = sWidth;
            Location = new Point(buttonShift.X, buttonShift.Y + i * (int)(Height * (1.05)));
            Visible = true;
            this.ship = ship;
            this.count = ship.count;
            this.field = field;

            // Increase static variable
            shipLeft += this.count;

            changeTextCount();
        }

        // Chaneg count view for button
        void changeTextCount()
        {
            Text = ship.name + " " + count;
        }

        // Button click handler
        protected override void OnClick(EventArgs e)
        {
            
            
            // If buttons unblocked and ships count > 0
            if( !active && count != 0 && shipLeft != 0)
            {
                // Decrese count of ships
                count -= 1;
                changeTextCount();

                // Put ship on the field
                field.PutShip(ship);

                // Update form status
                (this.Parent.Parent as Form1).setStatusLabel();

            }
        }



    }
}
