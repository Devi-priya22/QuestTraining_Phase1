using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;

namespace SocketProgramming.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var client = new TcpClient();
            client.Connect(ip, port);
            Console.WriteLine("Connecting to server...");

            while (true) 
            {
                Console.WriteLine("Client:");
                var message = Console.ReadLine();   
                byte[] data = Encoding.ASCII.GetBytes(message);
                client.GetStream().Write(data, 0, data.Length);

                byte[] response = new byte[1024];
                var dataLength = client.GetStream()
                    .Read(response, 0, response.Length);
                var responseText = Encoding.ASCII.GetString(response,0,dataLength);
                Console.WriteLine(responseText);

            }
        }
    }
}
