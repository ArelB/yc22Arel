using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Adapter : IBankAccount
    {
        public int totalAccount = 10;
        public string doTransaction(int amount)
        {
            totalAccount = totalAccount + amount;
            return "Current money is now: " + totalAccount;
        }

        public int getAmount()
        {
            return totalAccount;
        }
    }
}
