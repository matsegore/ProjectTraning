using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task4
{
    class Subtraction : Operation
    {

            public override void OperationForOperands(int firstOpernd, int secondOperand)
            {
                int subtraction = firstOpernd - secondOperand;
                Console.WriteLine($"Subtraction of values {subtraction}");
            }
        }
    }

