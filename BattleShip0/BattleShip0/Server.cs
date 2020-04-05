using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip0
{
    class Server : OtherPlayer
    {
        public static string endSimbol = "\\";
        Form1 arbitour;
         Socket handler; 
         public Server(Form1 arbitour)
        {
            this.arbitour = arbitour;
            // Get Host IP Address that is used to establish a connection  
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
            // If a host has multiple addresses, you will get a list of addresses  
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            try
            {

                // Create a Socket that will use Tcp protocol      
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method  
                listener.Bind(localEndPoint);
                // Specify how many requests a Socket can listen before it gives Server busy response.  
                // We will listen 10 requests at a time  
                listener.Listen(10);

                Console.WriteLine("Waiting for a connection...");
                handler = listener.Accept();
                Console.WriteLine("Connect!");

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void Send(String data)
        {
            try
            {            
                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void Receve()
        {
            try
            {
                // Incoming data from the client.    
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }

                Console.WriteLine("Text received : {0}", data);

                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
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
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch( Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void RecevePos(Point pos)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(pos.ToString() + Server.endSimbol);
                handler.Send(msg);
                  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void ReceveStatus(ShotStatus shotStatus)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(shotStatus.ToString() + Server.endSimbol);
                handler.Send(msg);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void SendPos()
        {
            try
            {
                var bytes = new byte[1024];

                // Receive the response from the remote device.    
                int bytesRec = handler.Receive(bytes);

                var responce = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                var pos = new Point();
                arbitour.RecevePos(pos);

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
                int bytesRec = handler.Receive(bytes);

                var responce = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                arbitour.ReceveStatus(ShotStatus.miss);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }

        }
    }
}

