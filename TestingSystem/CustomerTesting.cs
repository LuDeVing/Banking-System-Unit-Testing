using Banking_System;

namespace TestingSystem
{
    [TestClass]
    public class CustomerTesting
    {
        [TestMethod]
        [TestCategory("Constructor Test")]
        public void test_empty_name_errors()
        {

            Assert.ThrowsException<ArgumentNullException>(() => new Customer(123, "", "aaa"));

        }

        [TestMethod]
        [TestCategory("Constructor Test")]
        public void test_empty_email_errors()
        {

            Assert.ThrowsException<ArgumentNullException>(() => new Customer(123, "aaa", ""));

        }

        [TestMethod]
        [TestCategory("Function Test")]
        public void test_adding_account()
        {
            Customer c = new Customer(123, "a", "b");
            c.add_account(new CheckingAccount(1234, c, 1000000.0));
            c.add_account(new CheckingAccount(1235, c, 1000000.0));

            System.Console.WriteLine(c.get_number_of_accounts());

            Assert.AreEqual(2, c.get_number_of_accounts(), "expected 2 got " + c.get_number_of_accounts());
        }

    }
}