using System;
using RiceNet;

namespace RiceNet_Example
{
    class ServerExample
    {
        static void Main(string[] args)
        {
            Server server = new Server(45123);
            AcceptedClient acceptedClient = null;

            while (acceptedClient == null)
            {
                if (server.AcceptedClientsCount() > 0)
                    acceptedClient = server.GetAcceptedClient(0);
            }
            
            Console.WriteLine(acceptedClient.ReceiveString());

            server.Stop();
        }
    }
}
