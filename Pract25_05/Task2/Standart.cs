using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class Standart : BankAccount, IFreeOperation
    {
        public Standart (string owner, decimal currrentBalance, BankType bankType)
            :base (owner, currrentBalance, bankType)
        {
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
