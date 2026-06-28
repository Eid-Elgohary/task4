using System;
using System.Collections.Generic;
using System.Text;

namespace task4_Acount_
{
    internal class CheckingAccount : Account
    {
        public double fee { get; set; }


        public CheckingAccount(string _name = "Unnamed Account", double _balance = 0.0, double _fee = 1.50) : base(_name, _balance)
        {
            this.fee = _fee;
        }

        public override bool Withdraw(double amount)
        {
            if (amount + fee > Balance) return false;

            bool isSuccess = base.Withdraw(amount);

            if (isSuccess) Balance -= fee;

            return isSuccess;
        }

        public override string ToString()
        {
            return $"[Account: {Name}, balance {Balance} , fee {fee}]";
        }


    }
}
