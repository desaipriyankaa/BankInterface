using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    class DebitThroughCash : IBankDebit
    {
        decimal balance;
        public DebitThroughCash(decimal bal)
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
