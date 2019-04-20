using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        public static void Task1()
        {
            Console.WriteLine("Add first number: ");
            int firstArgiment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add second number: ");
            int secondArgument = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chuse operation:");
            string symbol = Console.ReadLine();

        }

        private static int Add(int firstnumb, int secondnumb)
        {
            int adding = firstnumb + secondnumb;
            return adding;
        }

        private static int Sub(int firstnumb, int secondnumb)
        {
            int subtr = firstnumb - secondnumb;
            return subtr;
        }

        private static int Mul(int firstnumb, int secondnumb)
        {
            int mult = firstnumb * secondnumb;
            return mult;
        }

        private static int Div(int firstnumb, int secondnumb)
        {
            int div = firstnumb * secondnumb;
            return div;
        }
    }
}
