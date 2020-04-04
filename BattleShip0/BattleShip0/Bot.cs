using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip0 
{
    enum Level
    {
        easy,
        medium,
        hard
    }
    class Bot : OtherPlayer
    {
        Level level;
        List<Point> positons; // Not shooten positions
        Field field;
        Form1 arbitrator;
        
        Random random = new Random();
        public Bot(Level level,Field field,Form1 arbitrator)
        {
            var fieldSize = field.GetSize();
            this.arbitrator = arbitrator;
            this.field = field;
            this.level = level;
            positons = new List<Point>();
            for (int x = 0; x < fieldSize.Width; x++)
                for (int y = 0; y < fieldSize.Height; y++)
                    positons.Add(new Point(x, y));



        }

        // Send pos to arbitr
        public void SendPos()
        {
            var i  = random.Next(positons.Count);
            var pos = positons[i];
            positons.Remove(pos);
            arbitrator.RecevePos(pos);
        }
        
        // Receve pos and send status and new pos to arbitr
        public void RecevePos(Point pos)
        {
            var status = field.Shot(pos);
            // Send status to atrbitour
            arbitrator.ReceveStatus(status);
        }

        public void ReceveStatus(ShotStatus status)
        {
            MessageBox.Show("Other player receve "+ status.ToString());
        }

}
}
