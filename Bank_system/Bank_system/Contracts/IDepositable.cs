﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_system.Contracts
{
   public  interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
