﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Template_Method
{
    public class Tea : Beverage
    {
        private bool _withCondiments = false;
        public Tea(bool withCondiments)
        {
            _withCondiments = withCondiments;
        }

        public override void AddBeverage()
        {
            Console.WriteLine("Adding teabag");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and lemon");
        }

        public override bool CondimentsNeeded()
        {
            return _withCondiments;
        }
    }
}
