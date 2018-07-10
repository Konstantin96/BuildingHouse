﻿using HomeBuilding.lib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.lib.Modul
{
    namespace HomeBuilding.lib.Modul.Home
    {
        class Walls : IPart
        {
            public ConsoleColor Color { get; set; } = ConsoleColor.White;
            public double SizeX { get; set; }
            public double SizeY { get; set; }
            public string Company
            {
                get; set;
            }

            public int Count
            {
                get; set;
            }

            public DateTime DateFinish
            {
                get; set;
            }

            public DateTime DateStart
            {
                get; set;
            }

            public string Material
            {
                get; set;
            }

            public double Price
            {
                get; set;
            }

            public int Sort { get; set; } = 1;
        }
    }
}