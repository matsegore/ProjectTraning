using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task4
{
    class Calculator
    {
        public void OperationValue()
        {
            Operation sum = new Sum();
            sum.OperationForOperands(2,3);
            Operation subtraction = new Subtraction();
            subtraction.OperationForOperands (2, 3);
            Operation multi = new Multiplication();
            multi.OperationForOperands(2, 3);
            Operation dev = new Devision();
            dev.OperationForOperands(2, 3);
        }
    }
}
