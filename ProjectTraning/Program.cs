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
            Task4();
        }

        public static void Task1()
            {
                Console.WriteLine("Введите колво секунд");
                int sec = Convert.ToInt32(Console.ReadLine());
                int hour = sec / 3600;
                Console.WriteLine($"Прошло полных часов {hour}");
                if (hour == 24)
                {
                    Console.WriteLine("Прошел 1 день");
                }
                else if (hour > 24)
                {
                    Console.WriteLine("Вы вышли за диапазон 1го дня");
                }
            }

        public static void Task2()
        {
            Console.WriteLine("Add number A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add number B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add number C");
            int C = Convert.ToInt32(Console.ReadLine());
            
            if ((B > A) & (B < C))
            {
                Console.WriteLine("Number B between A and C");
            }
            else
            {
                Console.WriteLine("Number B is not between A and C");
            }
        }
        public static void Task3()
        {
            Console.WriteLine("Add Number");
            int numb = Convert.ToInt32(Console.ReadLine());
            if ((numb % 2 != 0) & (numb <= 999) & (numb >= 100))
            {
                Console.WriteLine("Number three-digit and odd");
            }
            else
            {
                Console.WriteLine("The condition is not satisfied");
            }
        }
        public static void Task4()
        {
            int x = 10;
            int y = 12;
            int z = 3;
            x += y - x++ * z;
            Console.WriteLine($"First result {x}");
            z = --x - y * 5;
            Console.WriteLine($"Second result {z}");
            y /= x + 5 % z;
            Console.WriteLine($"Third result {y}");
            z = x++ + y * 5;
            Console.WriteLine($"Fourth result {z}");
            x = y - x++ * z;
            Console.WriteLine($"Fifth result {x}");
        }
    }
}
