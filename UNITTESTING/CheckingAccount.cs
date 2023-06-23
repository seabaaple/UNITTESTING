using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITTESTING
{
    public class CheckingAccount : Account
    {
        private double _overdraftFee = 25;

        public CheckingAccount(double balance) : base(balance)
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
                Balance -= _overdraftFee;
                return false;
            }
        }
    }
}
