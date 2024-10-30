using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoUsingServerBuilder
{
    public class ClientBuilder
    {

        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _client;
        private NetworkStream _stream;
        public void Connect()
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, port);
            _stream = _client.GetStream();
            Console.WriteLine("Connected to the server.");
        }
        public void SendMessage(string message)
        {
            var data = Encoding.ASCII.GetBytes(message);
            _stream.Write(data, 0, data.Length);
            Console.WriteLine($"Sent: {message}");

            var buffer = new byte[1024];
            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Received: {receivedMessage}");
        }
        public void Disconnect()
        {
            _stream.Close();
            _client.Close();
            Console.WriteLine("Disconnected from the server.");
        }
    }
}