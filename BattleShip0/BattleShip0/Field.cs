using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Data;



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

    enum FieldMode
    {
        filled,

    }

 
    class Field : GroupBox
    {
        
        Size size;
        Player player;
        Ship curShip; // Current ship to move
        Point curPos; // Current ship position
        bool curRotate; // Current ship rotation
        private List<Ship> ships; // List of the ships on the field 
        public Field() : base() {
           
        }

        public void Init(Size size,Player player,bool autoFill = false) 
        {
            this.size = size;
            this.player = player;
            GameInit.setField(this, size, player);
            ships = new List<Ship>();
            if (autoFill)
              RandomPutShip();
        }
        
        // Inicialization part---------------------------------------------

        // Make field empty
        public void Reset()
        {
            // Clear field and
            ships.Clear();
            GameInit.setField(this, size, player);

        }
        // Fill field in random way
        public void RandomPutShip()
        {
            if (player == Player.ally)
            {
                Reset();
                // block shipButtons
                ShipButton.ResetShipLeftToZero();

            }
            var random = new Random();
            //var ships =;
            foreach (var ship in GameInit.GetShips())
            {
                curShip = ship;
                for (int i = 0; i < curShip.count; i++)
                {
                   
                    bool possible, commit;
                    do
                    {
                        curPos = new Point(random.Next(0, size.Width - 1), random.Next(0, size.Height - 1));
                        curRotate = random.Next(10) % 2 == 0;

                        possible = PossiblePosition(curPos, curRotate);
                        commit = false;
                        if (possible)
                        {
                            PutShip(true);
                            commit = CanCommit();
                            if (!commit)
                                PutShip(false);
                            else
                                // Add ship to curships
                                ships.Add(new Ship(curShip));
                        }

                    } while (!(possible && commit));
                }
               
            }
        }

        // Put ship into field
        // to position pos
        // with rotation or not.
        // If ! fill then ship positions
        // will be cleaned
        void PutShip(bool fill)
        {
            FieldButtonState locState;
            if (fill)
               locState  = FieldButtonState.ship;
            else
                locState = FieldButtonState.empty;

            var locPos = this.size.Height * curPos.X + curPos.Y;
            int delta;
            if (curRotate)
                delta = this.size.Height;
            else
                delta = 1;
            for (int i = locPos, j = 0; j < curShip.size; i += delta, j++)
            {
                var newLocalState = locState;
                // if it's blended
                if (fill && ((FieldButton)this.Controls[i]).getState() == FieldButtonState.ship)
                    newLocalState = FieldButtonState.blended;
                if (!fill && ((FieldButton)this.Controls[i]).getState() == FieldButtonState.blended)
                    newLocalState = FieldButtonState.ship;

                ((FieldButton)this.Controls[i]).setState(newLocalState);

            }
        }


        public void PutShip(Ship ship)
        {

            //  block other ShipButtons 
            ShipButton.active = true;

            curShip = ship;
            curPos = new Point(0, 0);
            curRotate = false;
            PutShip(true);
        }

        FieldButton getFB(Point pos)
        {
            if (size.Width <= pos.X || size.Height <= pos.Y
                || pos.X < 0 || pos.Y < 0)
                return null;
            return (FieldButton)this.Controls[this.size.Height * pos.X + pos.Y];
        }

        // True if curShip in appropriate place in the field
        bool CanCommit()
        {
            UpdateCurShipCells();

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

        int ToInt(bool x)
        {
            if (x)
                return 1;
            return 0;
        }

        bool ToBool(int x)
        {
            if (x != 0)
                return true;
            return false;
        }

        // Change ship cells 
        // depending on curPos and curRot
        void UpdateCurShipCells()
        {
            curShip.cells.Clear();
            for (int i = 0; i < curShip.size; i++)
                curShip.cells.Add(new Point(curPos.X + i * ToInt(curRotate), curPos.Y + i * ToInt(!curRotate)));
            // Save copy of cells
            curShip.SaveCells();
        }
        // Commit position of curShip
        void CommitCurShip()
        {

            
            if (!CanCommit())
            {
                MessageBox.Show("You can't put " + curShip.name + " ship here");
                return;
            }
            // Unblock other buttons
            ShipButton.active = false;
            // Decrease ships count
            ShipButton.decreseShipLeft();
            // Put ship into the list
            ships.Add(curShip);
            
        }

        // return true if curShip appearing
        // in the pos and rot is possible
        bool PossiblePosition(Point pos,bool rot)
        {
            return (!
               (pos.X < 0 || pos.Y < 0 ||
                pos.X >= size.Width || pos.Y >= size.Height ||
               !rot && size.Height - pos.Y < curShip.size ||
               rot && size.Width - pos.X < curShip.size)
             ); 
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
            PutShip( false);

            Point newPos = new Point(curPos.X, curPos.Y);
            bool newRotate = curRotate;
            // Change ship position
            switch (direction) {
                case Direction.up:
                    newPos.X = curPos.X - 1;
                    break;
                case Direction.down:
                    newPos.X =  curPos.X + 1;
                    break;
                case Direction.left:
                    newPos.Y = curPos.Y - 1;
                    break;
                case Direction.right:
                    newPos.Y = curPos.Y + 1;
                    break;
                case Direction.rotate:
                    newRotate = !curRotate;
                    break;
            }

            // Constrains to ship position
            if ( PossiblePosition(newPos,newRotate))
            {
                // Set position
                curPos = newPos;
                curRotate = newRotate;
            }

        

            // Draw new ship
            PutShip( true);

        }

        public Size GetSize()
        {
            return size;
        }

        // Game part -------------------------------------------------

        // Make shot on this field
        // Return status of shot
        public ShotStatus Shot(Point pos)
        {
            if (player == Player.enemy)
            {
                throw new ConstraintException("Can't take a shot on the enemy field");
            }
            var button = getFB(pos);

            ShotStatus status = ShotStatus.miss;
            Ship ship = new Ship();
            bool skip = false;
            // Compute shot status
            if (button.getState() == FieldButtonState.ship)
            {
                for (int i = 0; i < ships.Count && !skip; i++)
                    if (ships[i].cells.Contains(pos))
                    {
                        ship = ships[i];
                        ships[i].cells.Remove(pos);
                        if (ships[i].cells.Count == 0)
                        {
                            ships.Remove(ships[i]);

                            status = ShotStatus.kill;
                        }
                        else
                            status = ShotStatus.hurt;
                        skip = true;

                    }
               
            }
            else
                status = ShotStatus.miss;

            // Change FieldButton state

            var FieldButton = getFB(pos);
            FieldButtonState state;
            switch(status){
                case ShotStatus.kill:
                    state = FieldButtonState.kill;
                    foreach (var c in ship.cellsInit)
                        getFB(c).setState(state);
                    if (ships.Count == 0)
                        status = ShotStatus.killEverybody;
                    break;
                case ShotStatus.hurt:
                    state = FieldButtonState.hit;
                    break;
                case ShotStatus.miss:
                    state = FieldButtonState.miss;
                    break;
                default:
                    state = FieldButtonState.blocked;
                    break;
            }
            getFB(pos).setState(state);

            return status;
            
        }

        // Visualize shot on enemy field
        public void Shot(Point pos,ShotStatus shotStatus)
        {
            if (player == Player.ally)
            {
                throw new ConstraintException("Can't view a shot on the ally field");
            }
            FieldButtonState state;
            if (shotStatus == ShotStatus.miss)
                state = FieldButtonState.miss;
            else if (shotStatus == ShotStatus.hurt)
                state = FieldButtonState.hit;
            else if (shotStatus == ShotStatus.kill)
                state = FieldButtonState.kill;
            else if (shotStatus == ShotStatus.killEverybody)
                state = FieldButtonState.kill;
            else
                state = FieldButtonState.blocked;
            getFB(pos).setState(state);

        }
        public void FieldButtonClicked(FieldButton button)
        {
            if ( player == Player.enemy)
            {
                (Parent as Form1).SendPos(button.GetPosition());
            }
        }
    }

    
}
