using System;

namespace BankingApp
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount()
        {
            _balance = 0m; 
        }

        public decimal GetBalance()
        {
            return _balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "You can only deposit a positive amount of money.");
            }

            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be greater than zero.");
            }

            //Prevent the account from going below zero 
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds. You cannot withdraw more than your current balance.");
            }

            _balance -= amount;
        }
    }
}