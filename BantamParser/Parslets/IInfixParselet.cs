﻿using BantamParser.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BantamParser.Parslets
{
    internal interface IInfixParselet
    {
        IExpression Parse(Parser parser, IExpression left, Token token);
        int getPredecence();
    }
}
