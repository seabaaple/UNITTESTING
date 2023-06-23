using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITTESTING
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(double balance) : base(balance)
        {
        }

        public override void Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
            }
        }

        public override bool Withdraw(double amount)
        {
            if (amount >= 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
