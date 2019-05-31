using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    interface IInterestRate
    {
        decimal CalculateOfRate();

        decimal InterestAccrual(decimal rate);
    }
}
