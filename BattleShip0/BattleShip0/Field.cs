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
        down  = 0,
        up    = 1,
        left  = 2,
        right = 3
    }

    class Field
    {
        GroupBox box;
        Size size;
        Player player;
        Ship curShip; // Current ship to move
        Point curPos; // Current ship position
        bool curRotated; // Current ship rotation
        public Field(GroupBox box,Size size,Player player)
        {
            this.box = box;
            this.size = size;
            this.player = player;
            GameInit.setField(box, size, player);
        }

        void PutShip(Point pos,bool rotated)
        {
            var locPos = this.size.Height * pos.X + pos.Y;
            int delta;
            if (rotated)
                delta = this.size.Height;
            else
                delta = 1;
            for (int i = 0; i < curShip.count*delta; i += delta)
                ((FieldButton)box.Controls[i]).setState(FieldState.ship);
        }

        public void PutShip(Ship ship)
        {
            curShip = ship;
            curPos = new Point(0, 0);
            curRotated = false;
            PutShip(curPos, curRotated);
        }

         
        public void MoveCurShip(Direction direction)
        {
            switch (direction) {
                case Direction.up:
                    curPos.Y = Math.Min(0, curPos.Y - 1);
                    break;
                case Direction.down:
                    curPos.Y = Math.Max(size.Height - 1, curPos.Y + 1);
                    break;
                case Direction.left:
                    curPos.X = Math.Min(0, curPos.X - 1);
                    break;
                case Direction.right:
                    curPos.Y = Math.Max(size.Width - 1, curPos.X + 1);
                    break;
            }
            
        }
    }
}
