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
            //Task4();
            //Task5();
            //Task6();
            Task7();
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

        public static void Task5()
        {
            Console.WriteLine("Add first number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add second number");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add ar operation");
            string sign = Console.ReadLine();
            int result;
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    if (operand1 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        result = operand1 / operand2;
                        Console.WriteLine(result);
                    }
                        break;
                    
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid sign");
                    break;
            }
        }

        public static void Task6()
        {
            Console.WriteLine("Add number");
            int numb = Convert.ToInt32(Console.ReadLine());
            if ((numb>100)||(numb<0))
            {
                Console.WriteLine("Error number out of range");
            }
            if ((numb>=0)&(numb<=14))
            {
                Console.WriteLine("Between 0-14");
            }
            if ((numb >= 15) & (numb <= 35))
            {
                Console.WriteLine("Between 15-35");
            }
            if ((numb >= 36) & (numb <= 50))
            {
                Console.WriteLine("Between 36-50");
            }
            if ((numb >= 50) & (numb <= 100))
            {
                Console.WriteLine("Between 50-100");
            }           
        }
        public static void Task7()
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            Console.WriteLine("Английская версия");
            string translation;
            switch (word)
            {
                case "зима":
                    translation = "winter";
                    Console.WriteLine(translation);
                    break;
                case "лето":
                    translation = "sumer";
                    Console.WriteLine(translation);
                    break;
                case "осень":
                    translation = "autumn";
                    Console.WriteLine(translation);
                    break;
                case "весна":
                    translation = "spring";
                    Console.WriteLine(translation);
                    break;
                case "дождь":
                    translation = "rain";
                    Console.WriteLine(translation);
                    break;
                case "снег":
                    translation = "snow";
                    Console.WriteLine(translation);
                    break;
                case "ветер":
                    translation = "wind";
                    Console.WriteLine(translation);
                    break;
                case "температура":
                    translation = "temperature";
                    Console.WriteLine(translation);
                    break;
                case "циклон":
                    translation = "cyclone";
                    Console.WriteLine(translation);
                    break;
            }
        }

    }
}
