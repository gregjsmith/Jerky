using System;

namespace Jerky.Tests.TestObjects
{
    public class Account
    {
        private readonly string _s;
        private int _balance;

        public Account(string s)
        {
            _s = s;
            _balance = 0;
            if (s == null) throw new ArgumentNullException("s");
        }

        public void Withdraw(int withdrawl)
        {
            SetBalance(-withdrawl);
        }

        private void SetBalance(int amount)
        {
            _balance += amount;
            if (_balance < 0)
            {
                throw new InvalidOperationException("You do not have enough funds");
            }
        }
    }
}