﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.DoYourThing();
            Console.ReadKey();
        }
    }
}
