using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace BankGUIProject
{
    internal class Transaction : BankAccount
    {
        private const int MaxTransactions = 100;

        private List<Transaction> recentTransactions = new List<Transaction>();

        public Transaction() : base() { }
        public Transaction(string fname, string lname, double balance) : base(fname, lname, balance) { }

        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public bool Type { get; set; } 

        public void TypeChoice()
        {
            if (Type)
                Console.WriteLine("Transaction Type: Withdraw");
            else
                Console.WriteLine("Transaction Type: Deposit");
        }

        public void BankTransaction(DateTime transactionDate, double amount)
        {
            TransactionDate = transactionDate;
            Amount = amount;
            LogTransaction();
        }

        private void LogTransaction()
        {
            if (recentTransactions.Count >= MaxTransactions)
            {
                recentTransactions.RemoveAt(0);
            }

            recentTransactions.Add(new Transaction
            {
                TransactionDate = this.TransactionDate,
                Amount = this.Amount,
                Type = this.Type
            });
        }

        public void CompleteTrans(string fname, string lname, double amount)
        {
            Console.WriteLine($"The account of {fname} {lname} had a transaction of {amount}");
            BankTransaction(DateTime.Now, amount);
        }

        public void DisplayRecentTransactions()
        {
            Console.WriteLine("Recent Transactions:");
            foreach (var transaction in recentTransactions)
            {
                string type = transaction.Type ? "Withdraw" : "Deposit";
                Console.WriteLine($"{transaction.TransactionDate}: {type} of {transaction.Amount}");
            }
        }
    }
}
