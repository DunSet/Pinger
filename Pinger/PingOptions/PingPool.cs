using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using Pinger.Intefaces;


namespace Pinger
{
    class PingPool : IPing
    {
        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping(); //Почему нельзя убрать? "System.Net.NetworkInformation"

        int ipCounter = 0;
         void IPing.Ping(int a, int b, int c, int d)
        {
            for (; c < 255; c++)
            {
                d = 250;

                for (; d < 255; d++)
                {

                   PingReply pingReply = ping.Send($"{a}.{b}.{c}.{d}");

                    if (pingReply.Status == IPStatus.Success)
                    {
                        //   Console.WriteLine("Time    " + pingReply.RoundtripTime); //время ответа
                        ipCounter++;

                        //       Console.WriteLine("Status  " + pingReply.Status);        //статус
                        Console.Write($"IP {a}.{b}.{c}.{d} ");       //IP
                                                                     //  Console.Write(pingReply.Options.Ttl);

                        Console.WriteLine();
                        if (c == 255)
                        {
                            Console.WriteLine($"Check is end! Count of ip answers: {ipCounter}");
                        }


                    }
                }
            }
        }
    }
}
