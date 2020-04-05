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
    class Client : OtherPlayer
    {
        Socket sender;
        Form1 arbitour;

        public Client(String adress,Form1 arbitour)
        {
            this.arbitour = arbitour;

            try
            {
                // Connect to a Remote server  
                // Get Host IP Address that is used to establish a connection  
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1  
                // If a host has multiple addresses, you will get a list of addresses  
                IPHostEntry host = Dns.GetHostEntry(adress);
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.    
                sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.    
                try
                {
                    // Connect to Remote EndPoint  
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

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
                var bytes = new byte[1024];

                // Receive the response from the remote device.    
                int bytesRec = sender.Receive(bytes);
                Console.WriteLine("Echoed test = {0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());

            }

        }

        public void Send(String data)
        {
            try
            { 
                // Encode the data string into a byte array.    
                var msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                // Send the data through the socket.    
                int bytesSent = sender.Send(msg);
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

        public void RecevePos(Point pos)
        {
            var msg = Encoding.ASCII.GetBytes(pos.ToString() + Server.endSimbol);

            // Send the data through the socket.    
            int bytesSent = sender.Send(msg);
        }

        public void ReceveStatus(ShotStatus shotStatus)
        {
            var msg = Encoding.ASCII.GetBytes(shotStatus.ToString() + Server.endSimbol);

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
                int bytesRec = sender.Receive(bytes);

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
