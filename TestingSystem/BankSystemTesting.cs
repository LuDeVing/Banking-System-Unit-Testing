using Banking_System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingSystem
{
    [TestClass]
    public class BankSystemTests
    {
        [TestMethod]
        public void AddCustomer_NewCustomer_DoesNotThrow()
        {
            var system = new BankSystem();
            system.add_customer(1, "aaaa", "aaaaaaaaa");
        }

        [TestMethod]
        public void AddCustomer_DuplicateCustomer_ThrowsException()
        {
            var system = new BankSystem();
            system.add_customer(1, "aaaa", "aaaaaaaaa");
            Assert.ThrowsException<Exception>(() => system.add_customer(1, "Bob", "bob@example.com"));
        }

        [TestMethod]
        public void AddAccount_CheckingAccount_DoesNotThrow()
        {
            var system = new BankSystem();
            system.add_customer(1, "aaaa", "aaaaaaaaa");
            system.add_account("checking", 1001, 1, 50.0);
        }

        [TestMethod]
        public void AddAccount_SavingAccount_DoesNotThrow()
        {
            var system = new BankSystem();
            system.add_customer(1, "aaaa", "aaaaaaaaa");
            system.add_account("saving", 1002, 1, 100.0);
        }

        [TestMethod]
        public void AddAccount_NonexistentCustomer_ThrowsException()
        {
            var system = new BankSystem();
            Assert.ThrowsException<Exception>(() => system.add_account("checking", 1003, 999, 0.0));
        }

        [TestMethod]
        public void AddAccount_InvalidAccountType_ThrowsException()
        {
            var system = new BankSystem();
            system.add_customer(1, "aaaa", "aaaaaaaaa");
            Assert.ThrowsException<Exception>(() => system.add_account("loan", 1004, 1, 0.0));
        }
    }
}
