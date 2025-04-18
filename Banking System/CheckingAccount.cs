using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int account_number, Customer customer, double balance)
        : base(account_number, customer, balance)
        {

        }

        public override void apply_interest()
        {
        }
    }
}
