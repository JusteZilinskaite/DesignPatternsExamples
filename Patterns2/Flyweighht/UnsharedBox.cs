﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Flyweighht
{
    public class UnsharedBox : Box
    {
        public UnsharedBox(int height, int width, int length) : base(height, width, length)
        {
        }
        public override void Display(string color)
        {
            Console.WriteLine("Unshared box: ({0},{1},{2}) in color {3}", Height, Width, Length, color);
        }
    }
}
