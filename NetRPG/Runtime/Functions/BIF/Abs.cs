﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Runtime.Functions.BIF
{
    class Abs : Function
    {
        public override object Execute(object[] Parameters)
        {
            dynamic param = Parameters[0];
            Math.Abs(param);
            return param;
        }
    }
}