﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Interpreter.Calculator
{
    public class NumberExpression : TerminalExpression
    {
        public int Number;

        public NumberExpression(int number)
        {
            Number = number;
        }
        public override int Evaluate()
        {
            return Number;
        }
    }
}
