﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal interface IBankAccount
    {
        public int getAmount();

        public string doTransaction(int amount);
    }
}
