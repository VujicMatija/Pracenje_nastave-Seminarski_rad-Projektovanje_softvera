using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        Socket osluskujuciSoket;
        bool kraj = false;

        public void Pokreni()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            osluskujuciSoket.Bind(endPoint);
            osluskujuciSoket.Listen();
            Console.WriteLine("Server je pokrenut! Čekam klijenta!");
            while (!kraj)
            { 
                Socket klijent = osluskujuciSoket.Accept();
                Console.WriteLine("Klijent se povezao");
                ClientHandler handler = new ClientHandler(klijent);
                handler.Handle();
            }
            
        }
    }
}
