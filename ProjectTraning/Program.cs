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
            Console.WriteLine("Hello");
            Console.WriteLine("Введите радиус");
            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);
            Console.WriteLine($"The square of the round {Program.PerformCalculation(radius)}");
        }


        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;
        }
    }
}
