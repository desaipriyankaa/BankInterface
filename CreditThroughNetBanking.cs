using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    class CreditThroughNetBanking : IBank
    {
        public decimal balance { get; set; }
        public CreditThroughNetBanking(decimal bal)
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
