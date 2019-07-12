using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task4
{
    class Sum : Operation
    {

        public override void OperationForOperands(int firstOpernd, int secondOperand)
        {
            int sum = firstOpernd + secondOperand;
            Console.WriteLine($"Sum of values {sum}");
        }
    }
}
