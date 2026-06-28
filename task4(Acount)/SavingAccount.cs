using System;
using System.Collections.Generic;
using System.Text;

namespace task4_Acount_
{
    internal class SavingsAccount:Account
    {
        public double intrestRate { get; set; } = 12;

        public SavingsAccount(string _name = "Unnamed Account", double _balance = 0.0, double _intrestRate = 12) : base(_name, _balance)
        {
            intrestRate = _intrestRate;
        }

        public override string ToString()
        {
            return $"[Account: {Name}, balance {Balance} , intrest rate {intrestRate}%]";
        }
    }
}
