﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSocket;

namespace MServer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncSocketListener.StartListening();
        }
    }
}
