using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EchoUsingServerBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerBuilder();

            var serverThread = new Thread(() =>
            {
                server.Run(message =>
                {
                    Console.WriteLine($"Received from client: {message}");
                    server.SendMessage($"Echo: {message}");
                });
            });

            serverThread.Start();

            Console.WriteLine("Press Enter to shut down the server...");
            Console.ReadLine();

            server.ShutDown();
            serverThread.Join();
        }
    }
}