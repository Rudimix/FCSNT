using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketTcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip;
            IPAddress loopback = IPAddress.Loopback;
            Console.WriteLine("Loopback address: " + loopback);
            IPAddress none = IPAddress.None;
            Console.WriteLine("None address: " + none);
            IPAddress any = IPAddress.Any;
            Console.WriteLine("Any address: " + any);
            IPAddress broadcast = IPAddress.Broadcast;
            Console.WriteLine("Broadcast address: " + broadcast);

            ip = IPAddress.Parse("123.45.67.89");
            Console.WriteLine("IP = " + ip.ToString());


            string Host = Dns.GetHostName();
            Console.WriteLine("\nMy comp name = " + Host);

            IPAddress[] addresses = Dns.GetHostAddresses(Host);
            Console.WriteLine("All ip of my comp:");
            foreach (IPAddress address in addresses)
            {
                Console.WriteLine(address+"\nAdress fam = "+address.AddressFamily);
            }

            IPHostEntry host1 = Dns.GetHostEntry("unn.ru");
            Console.WriteLine("\nUNN HostName = " + host1.HostName);

            foreach (IPAddress ip0 in host1.AddressList)
                Console.WriteLine("UNN ip = " + ip0.ToString());

            Console.ReadLine();
        }
    }
}