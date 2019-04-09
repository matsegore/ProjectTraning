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

            //Task1();
            //Task5();
            //Task5t();
            //Task6();
            //Task7();
            Task9();
            //Task16();

        }
        static void Task16()
        {
            Console.WriteLine("Add number");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            int n;
            int converting;
            string newNumb = "";
            Console.WriteLine("Chuse number for del");
            int del = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                n = a % 10;
                a /= 10;
                if (n != del)
                {

                    newNumb += n.ToString();

                }
            }
            int temp = 0;
            converting = Convert.ToInt32(newNumb);
            while (converting > 0)
            {
                temp *= 10;
                temp += converting % 10;
                converting /= 10;
            }
            Console.WriteLine(temp);
        }

        static void Task5()
        {
            int a = 1;
            int b = 4;
            int temp = 0;
            for (int i = a; i <= b; i++)
            {
                temp += i;

            }
            Console.WriteLine(temp);
        }

        static void Task5t()
        {
            int a = 1;
            int b = 4;
            int temp = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }

        }

        static void Task6()
        {
            Console.WriteLine("Add Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    temp++;
                }

            }
            Console.WriteLine(temp);
        }

        public static void Task1()
        {
            while (true)
            {
                Console.WriteLine("Input Value or N for exit: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {
                    int result = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        result = result * i;
                    }
                    Console.WriteLine($"F = {result}");
                }
                else
                {
                    Console.WriteLine("Add correct number");
                }
            }
        }

        public static void Task7()
        {
            Console.WriteLine("Add First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int temp = 0;
            if (b >= a)
            {
                for (int i = a; i <= b; i++)
                {
                    counter++;
                    temp += i;

                }
                int result = temp / counter;
                Console.WriteLine($"Average: {result}");
            }
            else
            {
                Console.WriteLine("Add correct diapason");
            }

        }

        public static void Task9()
        {
            Console.WriteLine("Add First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 1; i <= b; i++)
            {
                temp += a ;               
            }
            Console.WriteLine($"Произведение: {temp}");
        }
    }
}
