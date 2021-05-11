using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    class CreditThroughUPI : IBankCredit
    {
        public decimal balance { get; set; }
        public CreditThroughUPI(decimal bal)
        {
            balance = bal;
        }
        public decimal CreditMoney(decimal amount)
        {
            balance += amount;
            return balance;
        }
    }
}
