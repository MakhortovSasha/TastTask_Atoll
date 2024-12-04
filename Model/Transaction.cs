using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public abstract class Transaction
    {
        public Guid TransactionId { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }

        public Transaction(DateTime date, decimal amount)
        {
            TransactionId = Guid.NewGuid();
            Date = date;
            Amount = Math.Abs(amount);
        }

        public abstract string GetDetails();
    }


    public class IncomeTransaction : Transaction
    {
        public IncomeTransaction(DateTime date, decimal amount) : base(date, amount) { }

        public override string GetDetails()
        {
            return $"Income transaction| Amount: {Amount:C}, Date: {Date:G}.";
        }
    }


    public class ExpenseTransaction : Transaction
    {
        public ExpenseTransaction(DateTime date, decimal amount) : base(date, amount) { }

        public override string GetDetails()
        {
            return $"Expense transaction| Amount: -{Amount:C}, Date: {Date:G}.";
        }
    }
}
