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
        List<Ship> ships; // List of the ships on the field 
        public Field(GroupBox box,Size size,Player player)
        {
            this.box = box;
            this.size = size;
            this.player = player;
            GameInit.setField(box, size, player);
            ships = new List<Ship>();
        }

        // Put ship into field
        // to position pos
        // with rotation or not.
        // If ! fill then ship positions
        // will be cleaned
        void PutShip(Point pos,bool rotated,bool fill)
        {
            FieldButtonState locState;
            if (fill)
               locState  = FieldButtonState.ship;
            else
                locState = FieldButtonState.empty;

            var locPos = this.size.Height * pos.X + pos.Y;
            int delta;
            if (rotated)
                delta = this.size.Height;
            else
                delta = 1;
            for (int i = locPos, j = 0; j < curShip.size; i += delta, j++)
            {
                var newLocalState = locState;
                // if it's blended
                if (fill && ((FieldButton)box.Controls[i]).getState() == FieldButtonState.ship)
                    newLocalState = FieldButtonState.blended;
                if (!fill && ((FieldButton)box.Controls[i]).getState() == FieldButtonState.blended)
                    newLocalState = FieldButtonState.ship;

                ((FieldButton)box.Controls[i]).setState(newLocalState);

            }
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

        FieldButton getFB(Point pos)
        {
            if (size.Width <= pos.X || size.Height <= pos.Y
                || pos.X < 0 || pos.Y < 0)
                return null;
            return (FieldButton)box.Controls[this.size.Height * pos.X + pos.Y];
        }

        bool canCommit()
        {
            var res = true;
            for (int i = 0; i < curShip.size && res; i++)
            {
                res = getFB(curShip.cells[i]).getState() != FieldButtonState.blended;
                // Check all neigbors
                var pos = curShip.cells[i];
                for (int ki = -1; ki <= 1 && res; ki++)
                    for(int kj = -1; kj <= 1 && res; kj++)
                    {
                        var checkedPos = new Point(pos.X + ki, pos.Y + kj);
                        var curFB = getFB(checkedPos);
                        // if cell is another ship
                        if (curFB != null && !curShip.cells.Contains(checkedPos) && (getFB(checkedPos).getState() == FieldButtonState.ship))
                            res = false;
                    }

            }
            return res;
        }

        int toInt(bool x)
        {
            if (x)
                return 1;
            return 0;
        }

        // Commit position of curShip
        void CommitCurShip()
        {
            // Add cells to curShip
            curShip.cells.Clear();
            for (int i = 0; i < curShip.size; i++)
                curShip.cells.Add(new Point(curPos.X + i * toInt(curRotate), curPos.Y + i * toInt(!curRotate)));

            if (!canCommit())
            {
                MessageBox.Show("You can't put " + curShip.name + " ship here");
                return;
            }
            // Unblock other buttons
            ShipButton.active = false;
            // Put ship into the list
            
            ships.Add(curShip);
            
        }

         // Move current ship on the field
        public void MoveCurShip(Direction direction)
        {
            // If fiels hasn't current ship
            if (! ShipButton.active )
                return;

            // If it's commit
            if (direction == Direction.commit)
            {
                CommitCurShip();
                return;
            }

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
