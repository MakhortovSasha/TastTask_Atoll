using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask.Builder
{
    public static class TransactionFactory
    {
        public static Transaction CreateTransaction(DateTime date, decimal amount)
        {
            if (amount < 0)
                return new ExpenseTransaction(date, amount);
            else
                return new IncomeTransaction(date, amount);
        }
    }
}
