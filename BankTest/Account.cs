using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    public class Account
    {
        public int balance;

        public void deposit(int amount)
        {
            balance += amount;
        }
    }
}
