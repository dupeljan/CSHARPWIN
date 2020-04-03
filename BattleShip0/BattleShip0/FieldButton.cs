using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0
{   
    enum FieldButtonState
    {
        blocked,
        empty,
        ship,
        hit,
        kill,
        blended
    }
    class FieldButton : Button
    {
        public static Dictionary<FieldButtonState, Color> colors =
            new Dictionary<FieldButtonState, Color>
            {
                {FieldButtonState.empty, Color.Blue },
                {FieldButtonState.blocked, Color.Gray },
                {FieldButtonState.hit, Color.Pink },
                {FieldButtonState.kill, Color.Red },
                {FieldButtonState.ship, Color.Green },
                {FieldButtonState.blended, Color.Red }
            };

        Point pos; // Button pos in field
        FieldButtonState state;
        public FieldButton(Point pos, Point buttonShift,int fieldSize, FieldButtonState state= FieldButtonState.blocked) : base()
        {
            this.pos = pos;
           
            Height = fieldSize;
            Width = fieldSize;
            Location = new Point(buttonShift.X + pos.Y * Width, buttonShift.Y + pos.X * Height );
            setState(state);
        }

        public void setState(FieldButtonState state)
        {
            this.BackColor = colors[state];
            this.state = state;
        }

        public FieldButtonState getState()
        {
            return state;
        }
    }
}
