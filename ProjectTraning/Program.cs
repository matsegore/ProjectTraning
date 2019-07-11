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
            Task5();
        }

        public static void Task1()
        {
            Console.Write("Enter the number of elements in the array: ");

            int arrayLangth = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arrayLangth];

            Console.WriteLine("Fill array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Add number: ", i + 1);
                array[i] = Int32.Parse(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }

            }
            Console.WriteLine();
        }

        public static void Task2()
        {
            double[] arrayOfPrice = new double[10] { 40.50, 31.20, 21.80, 35, 150, 145, 200, 400, 81.40, 53.35 };

            string[] arrayOfNames = new string[10] { "Груши", "Яблоки", "Огурци", "Баклажаны", "Помидоры", "Петрушка", "Укроп", "Молоко", "Яйца", "Макароны" };

            int counter = 0;

            double sum = 0;

            for (int i = 0; i < arrayOfPrice.Length; i++)
            {
                counter++;
                Console.WriteLine($"{counter}) {arrayOfNames[i]} - {arrayOfPrice[i]}");
            }

            while (true)
            {
                Console.WriteLine("Выбери номер товара для добавления в корзину или 0 для выхода");

                int nomberOfProdukt = Convert.ToInt32(Console.ReadLine());

                if (nomberOfProdukt == 0)
                {
                    break;
                }
                Console.WriteLine("Введи количество");

                double countOfProduct = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < arrayOfPrice.Length; i++)
                {
                    if (nomberOfProdukt - 1 == Array.IndexOf(arrayOfPrice, arrayOfPrice[i]))
                    {
                        sum += arrayOfPrice[i] * countOfProduct;
                    }
                }
            }
            Console.WriteLine("Сумма:" + sum);
        }

        public static void Task3()
        {

            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static char[] Task4()
        {
            var arrayNumbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            var arraySymbols = new char[11] { ':', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            Console.WriteLine("Enter values");

            string arraySize = Console.ReadLine();

            var array = new int[arraySize.Length];

            var newArray = new char[arraySize.Length];

            int temp = 0;

            int counter = 0;

            for (int i = 0; i < arraySize.Length; i++)
            {
                array[i] = arraySize[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (array[i] == arrayNumbers[j])
                    {
                        newArray[temp] = arraySymbols[j];
                        temp++;
                    }
                    else
                    {
                        counter++;
                        if (counter == arrayNumbers.Length)
                        {
                            newArray[temp] = arraySymbols[arraySymbols.Length - 1];
                            temp++;
                        }
                    }

                }
                counter = 0;
            }

            Console.WriteLine("Result");

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            return newArray;
        }

        public static void Task5()
        {
            var arrayNumbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            var arraySymbols = new char[11] { ':', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            var array = Task4();

            var newArray = new char[array.Length];

            int temp = 0;

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < arraySymbols.Length; j++)
                {
                    if(array[i] == arraySymbols[j] && array[i] != '$')
                    {
                        newArray[temp] = arrayNumbers[j];
                        temp++;
                    }
                    else
                    {
                        counter++;

                        if (counter == arraySymbols.Length+1)
                        {
                            newArray[temp] = '$';

                            temp++;
                        }
                    }
                }
                counter = 0;
            }
            Console.WriteLine("Result");

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
    }
}

