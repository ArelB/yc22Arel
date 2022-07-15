using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class OldApp : IBankAccount
    {

        public int totalAmount = 5;
        public int getAmount()
        {
            return totalAmount;
        }

        public string doTransaction(int amount)
        {
            totalAmount = totalAmount + amount;
            return "Success";
        }
    }
}
