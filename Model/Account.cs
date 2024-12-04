using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask.Model
{
    public class Account
    {
        public string AccountName { get; set; }
        private List<Transaction> Transactions { get; set; }

        public Account(string accountName)
        {
            AccountName = accountName;
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public decimal GetBalance()
        {
            return Transactions.Sum(t => t is IncomeTransaction ? t.Amount : -t.Amount);
        }

        public List<T> GetTransactionsByType<T>() where T : Transaction
        {
            return Transactions.OfType<T>().ToList();
        }
    }
}
