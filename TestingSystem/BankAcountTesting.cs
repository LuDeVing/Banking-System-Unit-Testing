
using Banking_System;

namespace TestingSystem
{
    [TestClass]
    public class BankAcountTesting
    {

        [TestMethod]
        public void test_deposit_error() {
            
            BankAccount account = new CheckingAccount(1, null, 100.0);

            Assert.ThrowsException<ArgumentException>(() => account.deposit(-1.0));
        
        }

        [TestMethod]
        public void test_under_withdraw_error()
        {

            BankAccount account = new CheckingAccount(1, null, 100.0);

            Assert.ThrowsException<ArgumentException>(() => account.withdraw(-1.0));

        }

        [TestMethod]
        public void test_pver_withdraw_error()
        {

            BankAccount account = new CheckingAccount(1, null, 100.0);

            Assert.ThrowsException<ArgumentException>(() => account.withdraw(1000.0));

        }

        [DataTestMethod]
        [DataRow(100, 20, 100)]
        [DataRow(15, 1.6, 0)]
        [DataRow(1000000, 1234.1234, 1200)]
        public void test_transfer(double amount1, double give, double amount2)
        {

            BankAccount account1 = new CheckingAccount(1, null, amount1);
            BankAccount account2 = new CheckingAccount(2, null, amount2);

            BankAccount.transfer(give, account1, account2);

            bool correct_ammount1 = (account1.getBalance() == amount1 - give);
            bool correct_ammount2 = (account2.getBalance() == amount2 + give);

            Assert.IsTrue(correct_ammount1 && correct_ammount2);


        }

        [DataTestMethod]
        [DataRow(100)]
        [DataRow(1.1234)]
        [DataRow(999999.1234)]
        public void test_interests(double amount)
        {

            SavingsAccount account = new SavingsAccount(1, null, amount);

            account.apply_interest();

            Assert.AreEqual(amount + amount * account.getInterest(), account.getBalance(), "expected" + amount * account.getInterest() + " got " + account.getBalance());


        }

    }
}
