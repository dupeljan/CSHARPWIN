using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0
{
    enum Direction
    {
        down   = 0,
        up     = 1,
        left   = 2,
        right  = 3,
        rotate = 4,
        commit = 5
    }

    

    class Field
    {
        GroupBox box;
        Size size;
        Player player;
        Ship curShip; // Current ship to move
        Point curPos; // Current ship position
        bool curRotate; // Current ship rotation
        public Field(GroupBox box,Size size,Player player)
        {
            this.box = box;
            this.size = size;
            this.player = player;
            GameInit.setField(box, size, player);
        }

        // Put ship into field
        // to position pos
        // with rotation or not.
        // If ! fill then ship positions
        // will be cleaned
        void PutShip(Point pos,bool rotated,bool fill)
        {
            FieldState locState;
            if (fill)
                locState = FieldState.ship;
            else
                locState = FieldState.empty;

            var locPos = this.size.Height * pos.X + pos.Y;
            int delta;
            if (rotated)
                delta = this.size.Height;
            else
                delta = 1;
            for (int i = locPos, j = 0; j < curShip.size; i += delta,j++)
                ((FieldButton)box.Controls[i]).setState(locState);
        }

        public void PutShip(Ship ship)
        {

            //  block other ShipButtons 
            ShipButton.active = true;

            curShip = ship;
            curPos = new Point(0, 0);
            curRotate = false;
            PutShip(curPos, curRotate,true);
        }

        void CommitCurShip()
        {
            // Unblock other buttons
            ShipButton.active = false;

        }

         // Move current ship on the field
        public void MoveCurShip(Direction direction)
        {
            // If fiels hasn't current ship
            if (! ShipButton.active )
                return;
            // Clean previous move
            PutShip(curPos, curRotate, false);
            Point newPos = new Point(curPos.X, curPos.Y);
            bool newRotate = curRotate;
            // Change ship position
            switch (direction) {
                case Direction.up:
                    newPos.X = Math.Max(0, curPos.X - 1);
                    break;
                case Direction.down:
                    newPos.X = Math.Min(size.Width - 1, curPos.X + 1);
                    break;
                case Direction.left:
                    newPos.Y = Math.Max(0, curPos.Y - 1);
                    break;
                case Direction.right:
                    newPos.Y = Math.Min(size.Height - 1, curPos.Y + 1);
                    break;
                case Direction.rotate:
                    newRotate = !curRotate;
                    break;
                case Direction.commit: // commit ship in curr pos
                    CommitCurShip();
                    break;
            }

            // Constrains to ship position
            if (! 
               (!newRotate && size.Height - newPos.Y < curShip.size ||
               newRotate && size.Width - newPos.X < curShip.size)
               )
            {
                // Set position
                curPos = newPos;
                curRotate = newRotate;
            }

        

            // Draw new ship
            PutShip(curPos, curRotate, true);

        }
    }
}
