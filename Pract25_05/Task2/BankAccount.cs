using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class BankAccount
    {
        public decimal currrentBalance;

        public string owner;

        public BankAccount (string owner)
        {
            this.owner = owner;
        }

        public decimal Balance(decimal sum)
        {
            this.currrentBalance -= sum;
            return this.currrentBalance;
        }

        public string Owner()
        {
            return $"The owner of bank account is {this.owner}";
        }

        public string NullBalance (decimal sum)
        {
            this.currrentBalance -= sum;
            return $"Withdrawal amount {sum} sum for null of acc {this.currrentBalance}";
        }


    }
}
