﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0
{
    struct Ship
    {
        public string name;   
        public int size;  // Cells count of ship
        public int count;   // Count of ships on the field
        public List<Point> cells; // Ship position on the field
        public List<Point> cellsInit; // Copy of hip position on the field

        public Ship(string name,int size,int count)
        {
            this.name = name;
            this.size = size;
            this.count = count;
            this.cells = new List<Point>();
            this.cellsInit = new List<Point>();
        }

        public Ship(Ship ship)
        {
            this.name = ship.name;
            this.size = ship.size;
            this.count = ship.count;
            this.cells = new List<Point>();
            this.cellsInit = new List<Point>();
            foreach (var c in ship.cells) 
                this.cells.Add(c);
            foreach (var c in ship.cellsInit)
                this.cellsInit.Add(c);
        }
        public void SaveCells()
        {
            cellsInit.Clear();
            foreach (var c in cells)
                cellsInit.Add(c);
        }
    }
    class GameInit
    {
        public static Point Sum(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

       

        // static List<ShipButton> buttons;
        // Shift of init buttos position
        static Point buttonInitShift = new Point(10, 20);
        static Point buttonFieldShift = new Point(5, 15);
        static int fieldSize=30;

        
        // Ship sizes and count
        public static List<Ship> GetShips()
        {
            return new List<Ship>
            { new Ship("Biggest!", 4, 1),
             new Ship("Big one", 3, 2),
             new Ship("Middle", 2, 3),
             new Ship("Small", 1, 4),
            };
        }


        public static void ClearBox(GroupBox box)
        {
            var c = box.Controls.Count;
            for (int i = c - 1; i >= 0; i--)
                box.Controls.Remove(box.Controls[i]);
        }

        // fill 
        static int FillRandom() {
            return 0;
        }
        // Return list of init buttons
        //  update status - pdate form status method pointer
        public static void SetInitButtons(GroupBox box,Field field) 
        {
            // Clear groupBox
            ClearBox(box);
            var ships = GetShips();
            for ( int i = 0; i < ships.Count; i++)
                box.Controls.Add( new ShipButton(ships[i], buttonInitShift, i,field));
 
        }
    
        public static void setField(GroupBox box,Size size,Player player)
        {
            // Clear groupBox
            ClearBox(box);

            // Resize box
            box.Size = new Size(buttonFieldShift.X + size.Width * fieldSize, buttonFieldShift.Y + size.Height* fieldSize);

            // Set field type
            // and mode
            FieldButtonState type;
            ColorMode mode;
            if (player == Player.ally)
            {
                mode = ColorMode.normal;
                type = FieldButtonState.empty;
            }

            else
            {
                mode = ColorMode.silent;
                type = FieldButtonState.blocked;

            }

            // Add buttons to control
            for (int i = 0; i < size.Width; i++)
                for (int j = 0; j < size.Height; j++)
                    box.Controls.Add(new FieldButton(new Point(i, j), buttonFieldShift, fieldSize,type,mode));
        }

    }
}
