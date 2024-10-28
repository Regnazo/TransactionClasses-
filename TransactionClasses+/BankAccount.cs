using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUIProject
{
    internal class BankAccount
    {
        private Person mPerson;
        private double mBalance;

        public BankAccount()
        {
            mPerson = new Person();
            mBalance = 0;
        }
        public BankAccount(string fname, string lName)
        {
            mPerson = new Person(fname, lName);
            mBalance = 0;
        }
        public BankAccount(string fname, string lName, double balance)
        {
            mPerson = new Person(fname, lName);
            mBalance = balance;
        }
        public BankAccount(Person p, double balance)
        {
            mPerson = p;
            mBalance = balance;
        }
        public void SetBalance(double d)
        {
            if (d >= 0)
                mBalance = d;
            else
                Console.WriteLine("Balance is below zero");
        }
        public double GetBalance() { return mBalance; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                mBalance += amount;
                Console.WriteLine($"{amount}$ deposited to Account Balance");
            }
            else
                Console.WriteLine($"{amount}$ can't be added to Account Balance as the amount is zero or below zero");
        }
        public void Withdraw(double amount)
        {
            if(amount > 0 && amount <= mBalance)
            {
                mBalance -= amount;
                Console.WriteLine($"{amount} withdrawed from Account Balance");
            }
            else
                Console.WriteLine($"{amount} can't be withdrawn from Account Balance as the amount is too high");
        }
        public void Inquiry()
        {
            Console.WriteLine($"Your current Account Balance is {mBalance}");
        }

        public void Print()
        {
            Console.WriteLine($"Account Holder: {mPerson} and ..Account Balance: {mBalance} ");
        }

    }
}
