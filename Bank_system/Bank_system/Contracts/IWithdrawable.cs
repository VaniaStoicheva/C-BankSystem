﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_system.Contracts
{
    interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
