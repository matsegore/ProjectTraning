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
            short num1 = 10;
            short num2 = 15;
            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1, num2)}");
            Console.ReadLine();
            //Task2();
            //Task3();
            /*Console.WriteLine("Hello");
            Console.WriteLine("Введите радиус");
            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);
            Console.WriteLine($"The square of the round {Program.PerformCalculation(radius)}");
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;*/
        }

        public static void Task1()
        {
            int uberflu;
            int Identifire;
            int u00fidentifier;
            int myVar;
            int myVariable;

        }

        public static void Task2()
        {
            decimal pi = 3.141592653m;
            decimal e = 3.7182818284590452m;
            Console.WriteLine($"Число P: {pi}");
            Console.WriteLine($"Число Ейлера: {e}");
        }

        public static void Task3()
        {
            string a = "\nмоя строка1";
            string b = "\tмоя строка2";
            string c = "\aмоя строка3";
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

    }
}

