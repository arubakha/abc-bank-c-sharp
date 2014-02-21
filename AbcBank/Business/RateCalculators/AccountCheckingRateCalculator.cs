﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcBank.Business
{
    public class AccountCheckingRateCalculator : IAccountRateCalculator
    {
        public double Calculate(double amount)
        {
            return amount * 0.001;
        }
    }
}