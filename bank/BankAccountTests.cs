cleausing NUnit.Framework;
using System;

namespace BankingApp.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;
 
        [SetUp]
        public void Setup()
        {
            _account = new BankAccount();
        }

        [Test]
        public void NewAccount_StartsAtZero()
        { 
            // Act 
            decimal balance = _account.GetBalance();

            // Assert (Confirm results)
            Assert.That(balance, Is.EqualTo(0m), "A new account should always start with 0.");
        }

        [Test]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            // Act: Let's deposit 100
            _account.Deposit(100m);

            // Assert: Confirm balance is now 100
            Assert.That(_account.GetBalance(), Is.EqualTo(100m));
        }

        [Test]
        public void Deposit_BadAmount_ThrowsError()
        { 
            Assert.Throws<ArgumentOutOfRangeException>(() => _account.Deposit(-50m));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        { 
            _account.Deposit(200m);

            // Act
            _account.Withdraw(50m);

            // Assert
            Assert.That(_account.GetBalance(), Is.EqualTo(150m));
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsError()
        { 
            Assert.Throws<ArgumentOutOfRangeException>(() => _account.Withdraw(-20m));
        }

        [Test]
        public void Overdraft_ThrowsError()
        { 
            _account.Deposit(100m);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(150m), "You shouldn't be allowed to withdraw more than you have.");
        }
    }
}