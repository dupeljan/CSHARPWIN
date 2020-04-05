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
        blended,
        miss
    }
    enum ColorMode
    {
        silent,
        normal
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
                {FieldButtonState.blended, Color.Red },
                {FieldButtonState.miss, Color.Yellow }

            };

        Point pos; // Button pos in field
        FieldButtonState state;
        ColorMode mode;
        public FieldButton(Point pos, Point buttonShift, int fieldSize, 
            FieldButtonState state = FieldButtonState.blocked, ColorMode mode = ColorMode.normal) : base()
        {
            this.pos = pos;
           
            Height = fieldSize;
            Width = fieldSize;
            Location = new Point(buttonShift.X + pos.Y * Width, buttonShift.Y + pos.X * Height );
            this.mode = mode;
            setState(state);
        }

        public void Shot()
        {
            this.BackColor = colors[state];
        }
        public void setState(FieldButtonState state)
        {
            if ( !(
                mode == ColorMode.silent && 
                        ( state == FieldButtonState.ship ||
                          state == FieldButtonState.empty ||
                          state == FieldButtonState.blended)
                ) )
                this.BackColor = colors[state];
            this.state = state;
        }

        public FieldButtonState getState()
        {
            return state;
        }

        public Point GetPosition()
        {
            return pos;
        }

        protected override void OnClick(EventArgs e)
        {
            // If field already clicled
            if (state == FieldButtonState.kill ||
                state == FieldButtonState.miss ||
                state == FieldButtonState.hit)
                return;

            (Parent as Field).FieldButtonClicked(this);
        }
    }
}
