using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class Deposit : BankAccount, IInterestRate
    {
        public Deposit (string owner, decimal currrentBalance, BankType bankType)
            : base(owner, currrentBalance, bankType)
        {
        }

        public decimal CalculateOfRate()
        {
            decimal rate = this.currrentBalance * (decimal)0.1;
            return rate;
        }

        public decimal InterestAccrual(decimal rate)
        {
            decimal interestAccrual = this.currrentBalance + rate;
            return interestAccrual;
        }
    }
}
