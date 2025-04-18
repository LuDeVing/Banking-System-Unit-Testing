using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class BankSystem
    {

        private readonly List<Customer> customers;
        private readonly List<BankAccount> accounts;

        public BankSystem()
        {
            this.customers = new List<Customer>();
            this.accounts = new List<BankAccount>();
        }

        private bool Has_custumer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (id == customer.ID)
                {
                    return true;
                }
            }

            return false;
        }

        private Customer? Get_custumer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (id == customer.ID)
                {
                    return customer;
                }
            }

            return null;
        }

        public void add_customer(int id, string name, string email)
        {

            if (Has_custumer(id))
            {
                throw new Exception("customer already exists");
            }

            Customer c = new Customer(id, name, email);
            customers.Add(c);

        }

        public void add_account(string type, int account_number, int customer_id, double balance = 0.0)
        {

            Customer c = Get_custumer(customer_id);
            BankAccount b;

            if (c == null)
            {
                throw new Exception("customer does not already exist");
            }

            if (type == "checking")
            {
                b = new CheckingAccount(account_number, c, balance);
            }

            else if (type == "saving")
            {
                b = new SavingsAccount(account_number, c, balance);
            }

            else
            {
                throw new Exception("Invalid account type");
            }

            accounts.Add(b);
            c.add_account(b);

        } 

    }
}
