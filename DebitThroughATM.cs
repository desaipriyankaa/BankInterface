using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    class DebitThroughATM : IBankDebit
    {
        decimal balance;
        public DebitThroughATM(decimal bal)
        {
            balance = bal;
        }
        public decimal DebitMoney(decimal amount)
        {
            balance -= amount;
            return balance;
        }
    }
}
