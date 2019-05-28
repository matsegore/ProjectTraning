using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class Standart : BankAccount, IFreeOperation
    {
       public Standart (string owner)
            :base (owner)
        {

        }

        public decimal AddMoney(decimal sumOfAdding)
        {
            this.currrentBalance += sumOfAdding;
            return this.currrentBalance;
        }
    }
}
