using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class CraditCard : BankAccount, IInterestRate, IFreeOperation
    {
        public CraditCard (string owner)
            : base(owner)
        {

        }

        public decimal CalculateOfRate()
        {
            this.currrentBalance /= (decimal)0.1;
            return this.currrentBalance;
        }

        public void InterestAccrual(decimal rate)
        {
            Console.WriteLine($"Sum with accrual: {this.currrentBalance + rate}");
        }

        public decimal AddMoney(decimal sumOfAdding)
        {
            this.currrentBalance += sumOfAdding;
            return this.currrentBalance;
        }
    }
}
