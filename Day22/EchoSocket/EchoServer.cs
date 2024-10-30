using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerEcho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var listener = new TcpListener(ip, port);

            listener.Start();
            Console.WriteLine($"Server is listening...{ip}:{port}");

            var client = listener.AcceptTcpClient();
            Console.WriteLine("Client connected");

            var stream = client.GetStream();

            while (true)
            {
                var buffer = new byte[1024];
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Console.WriteLine($"Received message: {message}");

                stream.Write(buffer, 0, bytesRead);
                Console.WriteLine("Message echoed back to client");
            }

           
        }
    }
}
