﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger.Intefaces
{
   public interface IPing : IDisposable
    {
        void Ping(int a, int b, int c, int d); //Должен возвращать объект который будет вноситься в лист
        
    }
}
