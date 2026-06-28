using System;
using System.Collections.Generic;
using System.Text;

namespace task4_Acount_
{


    public class Account
    {
        protected string _name;
        protected double _balance;

        public string Name
        {
            get => _name;
            set
            {
                if (value == null || value.Length < 3) throw new Exception("you must enter a valid name");
                _name = value;
            }
        }
        public double Balance
        {
            get => _balance;
            set
            {
                if (value < 0) throw new Exception("balance must be over 0");
                _balance = value;
            }
        }

        public Account(string _name = "Unnamed Account", double _balance = 0.0)
        {
            this.Name = _name;
            this.Balance = _balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return $"[Account: {Name}: {Balance}]";
        }
    }



}
