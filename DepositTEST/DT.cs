using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UNITTESTING;

namespace DepositTEST
{
    [TestClass]
    public class DT
    {
        [TestMethod]
        public void AddsToBalance()
        {
            double startingBalance = 100;
            double depositAmount = 50;
            SavingsAccount account = new SavingsAccount(startingBalance);

            account.Deposit(depositAmount);

            Assert.IsTrue(account.Balance == startingBalance + depositAmount);
        }
            
        [TestMethod]
        public void DoesNotAddToBalance()
        {
            double startingBalance = 100;
            double depositAmount = -50;
            SavingsAccount account = new SavingsAccount(startingBalance);

            account.Deposit(depositAmount);

            Assert.IsTrue(account.Balance == startingBalance);
        }
    }
}
