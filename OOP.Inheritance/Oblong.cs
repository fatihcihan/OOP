﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Oblong : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Oblong drawing task.");
            // base.Draw();    // base -> ile temel classi cagirmis olduk.
        }
    }
}
