using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    public interface IBank
    {
        decimal CreditMoney(decimal amount);
        
    }
}
