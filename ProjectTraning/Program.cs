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
            /*int[] array = new int[] { 1, 2, 3 };
            
            MyReverse(array);
            int [] reversed = MyReverse(array);
            for (int i =0; i<reversed.Length; i++)
            {
                Console.WriteLine(reversed[i]);
            }*/
            int[] array = new int[] { 1, 2, 3, 5, 2, 7 };
            SubArray(array, 2, 4);

            foreach (var item in array)
            {
                Console.WriteLine(array[item]);
            }
        }
        public static void Task1()
        {
            Console.WriteLine("Задайте размер массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            var temp = new Random();

            Console.WriteLine("Заполните значениями массив");
            for (int i = 0; i < array.Length; i++)
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

        public static void Task2()
        {


            int[] array = new int[] { 5, 2, 3, 5, 8, 5 };
            int[] arrayWithoutDup = new int[6];
            arrayWithoutDup[0] = array[0];
            bool isDuplikate = false;
            int position = 1;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < position + 1; j++)
                {
                    if (array[i] == arrayWithoutDup[j])
                    {
                        isDuplikate = true;
                        break;
                    }
                    if (!isDuplikate)
                    {
                        arrayWithoutDup[position] = array[i];
                        position++;
                    }
                        isDuplikate = false;
                        
                    }
               
                }
            foreach (var item in arrayWithoutDup)
            {
                Console.WriteLine(arrayWithoutDup[item]);
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Add max");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add min");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add array length");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Заполните значениями массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Add number: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i< array.Length; i++)
            {
                if (max < array[i])
                {
                    Console.WriteLine($"Bigger than max: {array[i]}");
                }
                 else if (min > array[i])
                {
                    Console.WriteLine($"Less than min: {array[i]}");
                }
            }
        }

        public static void Task4()
        {
            Console.WriteLine("Задайте размер массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            var temp = new Random();

            Console.WriteLine("Заполните значениями массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp.Next(0, 1000);
                Console.WriteLine($"Значение массива {array[i]}");
            }
            int max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Сумма чисел: {sum}");
            sum /= array.Length;

            Console.WriteLine($"Среднее Арифметическое: {sum}");
            Console.WriteLine($"Числа которые больше средного арифметического: ");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static int[] MyReverse(int [] array)
        {
            int[] reversedArray = new int [array.Length];
            for (int i = 0; i < array.Length; i++)
            {              
                reversedArray[array.Length - i - 1]=array[i];               
            }
            return reversedArray;
        }
        public static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                if (index + count < array.Length)
                {
                    newArray[i] = array[index];
                }

            }
                
            return newArray;
        }

    }
    }
    



