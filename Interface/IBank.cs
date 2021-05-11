using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    public interface IBankCredit
    {
        decimal CreditMoney(decimal amount);
    }
}
