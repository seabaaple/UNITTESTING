using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITTESTING
{
    public abstract class Account
    {
        private double _balance;

        public Account(double balance)
        {
            _balance = balance;
        }

        public double Balance
        {
            get => _balance;
            protected set => _balance = value;
        }

        public abstract void Deposit(double amount);

        public abstract bool Withdraw(double amount);
    }
}
}
