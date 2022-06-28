using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("0.0.0.0");
            IPEndPoint endPoint = new IPEndPoint(ip, 7777);
            Socket listen_socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listen_socket.Bind(endPoint);
            listen_socket.Listen(10);
            Console.WriteLine("접속 준비");
            while (true)
            {
                listen_socket.Accept();

                Console.WriteLine("접속 성공");
                byte[] recvBuffer = new byte[1024];
                listen_socket.Receive(recvBuffer);

                Console.WriteLine(Encoding.Default.GetString(recvBuffer));
                listen_socket.Close();
            }
           
        }
    }
}
