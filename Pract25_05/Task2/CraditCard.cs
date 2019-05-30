using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class CraditCard : BankAccount, IInterestRate, IFreeOperation
    {
        public CraditCard (string owner, decimal currrentBalance, BankType bankType)
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

        public decimal AddMoney(decimal sumOfAdding)
        {
            this.currrentBalance += sumOfAdding;
            Console.WriteLine($"The sum after adding is: {this.currrentBalance}");
            return this.currrentBalance;
        }

        public decimal WithDrawBalance(decimal sum)
        {
            this.currrentBalance -= sum;
            Console.WriteLine($"The sum after WithDraw is: {this.currrentBalance}");
            return this.currrentBalance;
        }
    }
}
