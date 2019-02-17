using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using HelperLibrary;
using System.Threading;
using System.Timers;

namespace Server
{
    class Program
    {
        static List<Socket> socLst = new List<Socket>();
        static List<Person> perlst = new List<Person>();
        
       
        static void Main(string[] args)
        {
            Socket serverSoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            serverSoc.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.7"), 8080));
            Console.WriteLine("Server Started");

            Console.WriteLine("Awaiting Connection");

            serverSoc.Listen(50);
            Thread accept = new Thread(new ParameterizedThreadStart(Accept));
           
            accept.Start(serverSoc);
            Console.WriteLine("Client Connected");


        }

        public static void Accept(object obj)
        {
            Socket serverSoc = (Socket)obj;

            while (true)
            {

                Socket clientSoc = serverSoc.Accept();
                Console.WriteLine("Client Connected");

                Thread recieve = new Thread(new ParameterizedThreadStart(Recieve));
                recieve.Start(clientSoc);
                socLst.Add(clientSoc);
                
                perlst = MyDBHandler.GetData();

                foreach (Socket item in socLst)
                {
                    item.Send(perlst.Serialize());
                }

               

            }


        }

        static void Recieve(object obj)
        {
            Socket clientSoc = (Socket)obj;

            while (true)
            {

                byte[] buffer = new byte[clientSoc.ReceiveBufferSize];

                int amoutOfBytes = clientSoc.Receive(buffer);

                object test = buffer.Deserialize();

                if (test.ToString() == "1")
                {
                    Console.WriteLine("Client "+ clientSoc.RemoteEndPoint +" Refreshed");
                }
                else
                {
                    Person newPer = new Person();
                    newPer = (Person)buffer.Deserialize();

                    MyDBHandler.Insert(newPer);


                    perlst = MyDBHandler.GetData();

                    foreach (Socket item in socLst)
                    {
                        item.Send(perlst.Serialize());
                    }
                }

               

            }


        }
    }
}
