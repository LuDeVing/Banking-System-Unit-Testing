using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Customer {

        public int ID { get; }
        protected string name { get; set; }
        protected string email { get; set; }
        protected List<BankAccount> accounts;


        public Customer(int ID, string name, string email)
        {

            this.ID = ID;

            if (name == "")
            {
                throw new ArgumentNullException("name");
            }

            if (email == "")
            {
                throw new ArgumentNullException("email");
            }

            this.accounts = new List<BankAccount>();

            this.name = name;
            this.email = email;
        
        }

        public void add_account(BankAccount account)
        {
            accounts.Add(account);
        }

        public int get_number_of_accounts()
        {
            return accounts.Count;
        }

    }
}
