using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace task4_Acount_
{
    internal class TrustAccount : SavingsAccount
    {
        public int withdrawlsCount { get; set; }

        public DateTime accountStartingDate { get; set; }
        public DateTime pastDate { get; set; }

        public TrustAccount(string _name = "Unnamed Account", double _balance = 0.0, double _intrestRate = 12) : base(_name, _balance)
        {
            pastDate = accountStartingDate = DateTime.Now;
            withdrawlsCount = 0;
            intrestRate = _intrestRate;
        }
        public override bool Deposit(double amount)
        {
            bool isSuccess = base.Deposit(amount);
            if (amount >= 5000) Balance += 50;
            return isSuccess;
        }
        public override bool Withdraw(double amount)
        {

            if (AccountUtil.isPAssedYear(pastDate))
            {
                withdrawlsCount = 0;
                pastDate = DateTime.Now;
            }

            if (withdrawlsCount >= 3) return false;

            if (amount > Balance * .2) return false;


            bool isSucces = base.Withdraw(amount);
            if (isSucces)
                withdrawlsCount++;



            return isSucces;

        }


        public override string ToString()
        {
            return $"[Account: {Name}, balance {Balance} , withdrawls count  {withdrawlsCount}]";
        }

    }
}
