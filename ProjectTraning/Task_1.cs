using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Task_1
    {
        public static void Task1()
        {
            Console.WriteLine("Add first number: ");
            double firstArgiment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add second number: ");
            double secondArgument = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chuse operation:");
            string symbol = Console.ReadLine();
            Console.WriteLine (ShowResult (firstArgiment, secondArgument, symbol));
            
        }
        private static double Check (double firstnumb, double secondnumb)
        {
            if (!Int32.TryParse(Console.ReadLine(), out int operand1))
            {
                Console.WriteLine("Add correct value");
                continue;
            }
        }
        public static double WhitchSign (double firstnumb, double secondnumb, string symbol)
        {
            double result =0;
            switch (symbol)
            {

                case "+":
                    result = Task_1.Add(firstnumb, secondnumb);
                    break;
                case "-":
                    result =  Sub(firstnumb, secondnumb);
                    break;
                case "/":
                    if (firstnumb == 0 || secondnumb == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        result = Div(firstnumb, secondnumb);
                    }
                    break;

                case "*":
                    result = Mul(firstnumb, secondnumb);
                    break;
                default:
                    Console.WriteLine("Invalid sign");
                    break;
                    
            }
            return result;
        }

        private static double Add(double firstnumb, double secondnumb)
        {
            return firstnumb + secondnumb;
        }

        private static double Sub(double firstnumb, double secondnumb)
        {
            return firstnumb - secondnumb;
        }

        private static double Mul(double firstnumb, double secondnumb)
        {
            return firstnumb * secondnumb;
        }

        private static double Div(double firstnumb, double secondnumb)
        {
            return firstnumb * secondnumb;
        }


        private static double ShowResult (double firstnumb, double secondnumb, string symbol)
        {
            return WhitchSign(firstnumb, secondnumb, symbol);
        }
    }
}


