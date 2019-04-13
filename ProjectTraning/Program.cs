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
            Console.WriteLine("Задайте размер массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            var temp = new Random();

            Console.WriteLine("Заполните значениями массив");
            for (int i=0; i<array.Length; i++)
            {          
                array[i] = temp.Next(0, 1000);
                Console.WriteLine($"Значение массива {array[i]}");
            }
            int max = array[0];
            int min = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }

            }
            Console.WriteLine($"Максимально число массива: {max}");
            Console.WriteLine($"Минимальное число массива: {min}");

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Сумма чисел: {sum}");
           
                sum /= array.Length;
           
            Console.WriteLine($"Среднее Арифметическое: {sum}");
            Console.WriteLine($"Нечетные числа: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

    }
}
