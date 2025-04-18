using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public abstract class BankAccount
    {

        protected int account_number { get; }
        protected readonly Customer owner;
        protected double balance { get; set; }

        public BankAccount(int account_number, Customer owner, double balance=0.0)
        {

            this.owner = owner;
            this.balance = balance;
            this.account_number = account_number;
        }

        public Customer Owner => owner;

        public void deposit(double amount)
        {

            if (amount <= 0)
            {
                throw new ArgumentException("amount must be more than 0");
            }

            this.balance += amount;

        }

        public void withdraw(double amount)
        {
            if (amount <= 0) {
                throw new ArgumentException("amount must be more than 0");
            }

            if (amount > this.balance) {
                throw new ArgumentException("you cannot withdraw more than you have");
            }

            this.balance -= amount;

        }


        public static void transfer(double amount, BankAccount accountFrom, BankAccount accountTo) { 
            
            accountFrom.withdraw(amount);  
            accountTo.deposit(amount);
        
        }

        public double getBalance()
        {
            return balance;
        }

        public abstract void apply_interest();

    }
}
