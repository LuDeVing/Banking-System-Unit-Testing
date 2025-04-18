using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class SavingsAccount : BankAccount
    {

        private double interest_rate { get; set; }

        public SavingsAccount(int account_number, Customer customer, double balance = 0.0, double interest_rate = 0.0)
        : base(account_number, customer, balance)
        {
            this.interest_rate = interest_rate;
        }

        public double getInterest()
        {
            return interest_rate;
        }

        public override void apply_interest()
        {
            balance = balance + balance * interest_rate;
        }

    }
}
