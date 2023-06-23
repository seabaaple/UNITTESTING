using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UNITTESTING;

namespace WithdrawTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Withdraw_PositiveAmount_SubtractsFromBalance()
        {
            double startingBalance = 100;
            double withdrawalAmount = 50;
            SavingsAccount account = new SavingsAccount(startingBalance);

            bool result = account.Withdraw(withdrawalAmount);

            Assert.IsTrue(result && account.Balance == startingBalance - withdrawalAmount);
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_DoesNotSubtractFromBalance()
        {
            double startingBalance = 100;
            double withdrawalAmount = -50;
            SavingsAccount account = new SavingsAccount(startingBalance);

            bool result = account.Withdraw(withdrawalAmount);

            Assert.IsFalse(result && account.Balance == startingBalance);
        }

    }

    [TestClass]
    public class CheckAccount_Withdraw_Test
    {
        [TestMethod]
        public void Withdraw_PositiveAmount_SubtractsFromBalance()
        {
            double startingBalance = 100;
            double withdrawalAmount = 50;
            CheckingAccount account = new CheckingAccount(startingBalance);
            bool result = account.Withdraw(withdrawalAmount);

            Assert.IsTrue(result && account.Balance == startingBalance - withdrawalAmount);
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_DoesNotSubtractFromBalance()
        {
            double startingBalance = 100;
            double withdrawalAmount = -50;
            CheckingAccount account = new CheckingAccount(startingBalance);

            bool result = account.Withdraw(withdrawalAmount);

            Assert.IsFalse(result && account.Balance == startingBalance);
        }
    }
}
