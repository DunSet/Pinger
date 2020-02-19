using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Pinger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d; a = 192; b = 168; c = 8; d = 0;

            PingPool one = new PingPool();

            System.Net.NetworkInformation.Ping ping33 = new System.Net.NetworkInformation.Ping();
            ping33.Send("192.168.1.1");
            
            PingReply oneping = ping33.Send("192.168.1.10");

            List<PingReply> ipList = new List<PingReply>();
            
            Console.WriteLine("Buff " +oneping.Buffer);
            Console.WriteLine("Trip time miliseconds "+oneping.RoundtripTime);
            Console.WriteLine("TTL " +oneping.Options.Ttl);
            Console.WriteLine("Address " + oneping.Address);

            ipList.Add(oneping);
            Console.WriteLine("-------------");
            foreach (var item in ipList)
            {
                Console.WriteLine(item.Address);
            }
            //  PingReply tst = ping33.Send($"192.168.155.234");
            //  Console.WriteLine(ping33.);
            Console.ReadLine();

        }
    }
}
