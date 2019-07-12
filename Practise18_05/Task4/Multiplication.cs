using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task4
{
    class Multiplication: Operation
    {
        public override void OperationForOperands(int firstOpernd, int secondOperand)
        {
            int multiplication = firstOpernd * secondOperand;
            Console.WriteLine($"Devision of values {multiplication}");
        }
    }
}
