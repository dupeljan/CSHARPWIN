using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip0
{
    abstract class RemotePlayer : OtherPlayer
    {
        char separator = '-';
        string point = "P";
        string status = "S";

        protected Socket sender;
        protected Form1 arbitor;

        protected RemotePlayer(Form1 arbitor)
        {
            this.arbitor = arbitor;
        }

        public void RecevePos(Point pos)
        {
            var data = point + separator + pos.X.ToString() + separator + pos.Y.ToString();
            var msg = Encoding.ASCII.GetBytes(data);

            // Send the data through the socket.    
            int bytesSent = sender.Send(msg);
        }

        public void ReceveStatus(ShotStatus shotStatus)
        {
            var data = status + separator + ((int)shotStatus).ToString();
            var msg = Encoding.ASCII.GetBytes(data);

            // Send the data through the socket.    
            int bytesSent = sender.Send(msg);
        }

        public void SendPos()
        {
            try
            {
                var bytes = new byte[1024];

                // Receive the response from the remote device.    
                int bytesRec = sender.Receive(bytes);

                var responce = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                var splitRes = responce.Split(new char[]{ separator},3);
                
                var pos = new Point(Int32.Parse(splitRes[1]), Int32.Parse(splitRes[2]));
                arbitor.RecevePos(pos);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void SendStatus()
        {
            try
            {
                var bytes = new byte[1024];

                // Receive the response from the remote device.    
                int bytesRec = sender.Receive(bytes);

                var responce = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                var splitRes = responce.Split(new char[] { separator }, 2);
                var status = (ShotStatus)Int32.Parse(splitRes[1]);

                arbitor.ReceveStatus(status);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void Release()
        {
            try
            {
                // Release the socket.    
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



    }
}
