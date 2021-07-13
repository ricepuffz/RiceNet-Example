using System;
using System.Threading;
using RiceNet;

namespace Client_Example
{
    class ClientExample
    {
        static void Main(string[] args)
        {
            Client client = new Client("localhost", 45123);
            client.SendString("beep boop hi :)");

            Thread.Sleep(1000);
        }
    }
}
