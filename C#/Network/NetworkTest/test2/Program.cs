using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            IPAddress ip = IPAddress.Parse(s);
            //IPAddress ip = IPAddress.Parse("49.170.231.107");
            IPEndPoint endPoint = new IPEndPoint(ip, 7777);
            Socket conn_socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


            while (true)
            {
                conn_socket.Connect(endPoint);
                Console.WriteLine("접속 성공");
                string response = "test";
                byte[] sendBuffer = Encoding.Unicode.GetBytes(response);

                conn_socket.Send(sendBuffer);

                conn_socket.Close();
            }
            
        }
    }
}
