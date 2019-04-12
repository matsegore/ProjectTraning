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
            //Task2();
            //Task3();
            //Task5();
            //Task5t();
            //Task6();
            //Task7();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //Task16();
            //Task17();
            Task18();
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
                temp += a;

            }
            if (b < 0)
            {
                for (int k = b; k <= (-1); k++)
                {
                    temp += (-a);

                }

            }
            Console.WriteLine($"Proizvedeniye: {temp}");
        }
        public static void Task10()
        {
            Console.WriteLine("Add Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 1; i <= a; i++)
            {
                temp = i * i;
                if (temp <= a)
                {
                    Console.WriteLine(temp);
                }
            }
        }

        public static void Task11()
        {
            Console.WriteLine("Add Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int k = 1;
            Console.WriteLine("Fibonachi numbers: ");
            Console.WriteLine(temp);
            Console.WriteLine(k);
            for (int i = 0; i <= a; i++)
            {
                temp = temp + k;
                k = k + temp;

                if (temp < a)
                {
                    Console.WriteLine(temp);

                }
                if (k < a)
                {
                    Console.WriteLine(k);

                }
                if ((temp > a) | (k > a))
                {
                    break;
                }

            }

        }

        public static void Task12()
        {
            Console.WriteLine("Add Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine("Fib Numbers:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < n - 2; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b);
            }

        }

        public static void Task13()
        {
            Console.WriteLine("Add Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int renumber = 0;
            while (number > 0)
            {
                renumber *= 10;
                renumber += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Overturn:{renumber}");
        }

        public static void Task2()
        {
            int a, b, c;
            for (a = 1; a <= 5; a++)
            {
                for (b = 4; b >= a; b--)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= (2 * a - 1); c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Task14()
        {
            Console.WriteLine("Add Number");
            string number = Console.ReadLine();
            int number2 = Convert.ToInt32(number);
            int renumber = 0;
            int temp;
            while (number2 > 0)
            {
                renumber *= 10;
                renumber += number2 % 10;
                number2 /= 10;
            }
            Console.WriteLine("Numbers:");
            for (int i = 0; i < number.Length; i++)
            {
                temp = renumber % 10;
                renumber /= 10;

                Console.WriteLine(temp);
            }

        }

        public static void Task3()
        {
            Console.WriteLine("Add Number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool b = true;
            string text = "";
            if (number >= 0)
            {
                int temp = number;
                for (int i = 2; i <= number; i++)
                {
                    b = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            b = false;
                            break;
                        }
                    }
                }
                if (b == true)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    Console.WriteLine("Not prime number");
                }
                Console.WriteLine("Positive Number");

                if (temp % 2 == 0)
                {                    
                    text += "2" + " ";
                }
                if (number % 5 == 0)
                {                   
                    text += "5" + " ";
                }
                if (number % 3 == 0)
                {                   
                    text += "3" + " ";
                }           
                if (number % 6 == 0)
                {                     
                    text += "6" + " ";
                }
                if (number % 9 == 0)
                {                   
                    text += "9"+" ";
                }
                Console.WriteLine("Divides without balance on: " + text);
            }
            else
            {
                Console.WriteLine("Negative number");              
            }
        }

        public static void Task15()
        {
            Console.WriteLine("Add Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Exponent");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            for (int i =1; i<number2; i++)
            {
                temp *= number;
                

            }
            Console.WriteLine("Result:" + temp);
        }

        public static void Task17()
        {
            Console.WriteLine("Add Number");
            int number = Convert.ToInt32(Console.ReadLine());
            string numbers = number.ToString();
            int temp = 0;
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                temp = number % 10;
                number /= 10;
                
                if (max < temp)
                {
                    max += temp;
                }
                
            }
            Console.WriteLine(max);
        }

        public static void Task18()
        {
            Console.WriteLine("Add Number");
            int number = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Operation for Odd number");
                while (number > 1)
                {
                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else if (number % 2 != 0)
                    {
                        number *= 3;
                        number += 1;
                    }
                    Console.WriteLine(number);
                }
            }          
        }

    }
}


