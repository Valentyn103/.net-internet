using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
namespace CheckPort
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipEndPoint;
            IPEndPoint ipEndPoint1 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            for (int i = 1; i < 65000; i++)
            {
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), i);
                try
                {
                    TcpClient tcpClient = new TcpClient(ipEndPoint);
                    tcpClient.Connect(ipEndPoint1);
                    Console.WriteLine("Check port : " + i + ".\t\t" + "Port open");
                }
                catch (Exception e)
                { 
                    //Console.WriteLine("Check port : " + i + ".\t\t" + "Port block");
                }
            }
        }
    }
}
