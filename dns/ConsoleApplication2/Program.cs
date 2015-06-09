using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1)Enter Host name");
            Console.WriteLine("(2)Enter IP");
            string number = Console.ReadLine();
            if (Int32.Parse(number) == 1)
            {
                string hostname = Console.ReadLine();
                var ips1 = Dns.GetHostAddresses(hostname);
                foreach (var a in ips1)
                {
                    Console.WriteLine("Main : " + a );
                    foreach (var dns in Dns.GetHostEntry(a).AddressList)
                        Console.WriteLine("Dns : " + dns);
                    Console.WriteLine();
                }
            }
            if (Int32.Parse(number) == 2)
            {
                string ip = Console.ReadLine();
                var ips2 = Dns.GetHostEntry(ip);
                Console.WriteLine(ips2.HostName);
            }
        }
    }
}
