using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketProgramming.Server
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

            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client connected");

            while(true)
            {
                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                Console.WriteLine($"message received:{message}");
                Console.WriteLine("server");
                string response = Console.ReadLine();
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                socket.Send(responseData);
            }
          
            socket.Close();
            listener.Stop();
        }
    }
}
