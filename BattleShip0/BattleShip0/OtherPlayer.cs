using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip0
{
    interface OtherPlayer
    {
        // Receve pos and send status to arbitor
        void RecevePos(Point pos);
        void ReceveStatus(ShotStatus shotStatus);
        void SendPos();
        void SendStatus();
    }
}
