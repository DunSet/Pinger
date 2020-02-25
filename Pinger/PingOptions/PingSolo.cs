using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using Pinger.Intefaces;

namespace Pinger
{
    class PingSolo : IPing
    {
       
        void IPing.Ping(int a, int b, int c, int d)
        {
           
        }

        public void Dispose()
        {
            throw new Exception();
        }
    }
}
