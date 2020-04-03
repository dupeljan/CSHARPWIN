using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0
{   
    enum FieldState
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
        public static Dictionary<FieldState, Color> colors =
            new Dictionary<FieldState, Color>
            {
                {FieldState.empty, Color.Blue },
                {FieldState.blocked, Color.Gray },
                {FieldState.hit, Color.Pink },
                {FieldState.kill, Color.Red },
                {FieldState.ship, Color.Green },
                {FieldState.blended, Color.Red }
            };

        Point pos; // Button pos in field
        FieldState state;
        public FieldButton(Point pos, Point buttonShift,int fieldSize, FieldState state= FieldState.blocked) : base()
        {
            this.pos = pos;
           
            Height = fieldSize;
            Width = fieldSize;
            Location = new Point(buttonShift.X + pos.Y * Width, buttonShift.Y + pos.X * Height );
            setState(state);
        }

        public void setState(FieldState state)
        {
            this.BackColor = colors[state];
            this.state = state;
        }
    }
}
