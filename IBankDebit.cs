using System;
using System.Collections.Generic;
using System.Text;

namespace BankInterface
{
    public interface IBankDebit
    {
        decimal DebitMoney(decimal amount);
    }
}
