using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTest;

namespace BankTestTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void AccountShouldHaveABalance()
        {
            Account account = new Account();
            Assert.AreEqual(account.balance, 0);
        }

        [TestMethod]
        public void MakingADepositIncreasesTheAccountBalance()
        {
            Account account = new Account();
            account.deposit(10);
            Assert.AreEqual(account.balance, 10);
        }


    }
}
