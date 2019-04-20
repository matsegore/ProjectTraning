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
            //Task2();
            //Task6();
            //int[] startArray = new int[] { 1, 2, 3,4,0,5,6 };
            //Console.WriteLine(string.Join(",", SubArray(startArray, 5, 10)));
            //Task7();
            //Task8();
            //Task9();
            Task10();
        }
        public static void Task6()
        {
            Console.Write("Add size of the array: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add start index for copy: ");
            int fitstPoint = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add number of items: ");
            int numberItems = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];
            int[] receivingArray;

            Random randNumbers = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNumbers.Next(0, 100);
                Console.WriteLine(array[i]);
            }
            receivingArray = NewArray(array, fitstPoint, numberItems);

            Console.WriteLine("New Array");

            for (int i = 0; i < receivingArray.Length; i++)
            {
                Console.WriteLine(receivingArray[i]);
            }

            int[] NewArray(int[] arr, int index, int count)
            {
                int[] tempArr = new int[count];
                int j = 0;
                int size = index + count;
                for (int i = index; i < size; i++)
                {
                    if (i < arr.Length)
                    {
                        tempArr[j++] = arr[i];
                    }
                    else
                    {
                        tempArr[j++] = 1;
                    }
                }

                return tempArr;
            }
        }

        public static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            int subArrayPoisition = 0;

            for (int i = index; subArrayPoisition < count; i++)
            {
                subArray[subArrayPoisition++] = array[i];
                if (array.GetUpperBound(0) == i)
                {
                    break;
                }
            }
            for (int i = subArrayPoisition; i < count; i++)
            {
                subArray[i] = 1;
            }
            return subArray;

        }
        public static void Task7()
        {
            int[] startArray = new int[] { 1, 2, 3, 4, 0, 5, 6 };
            Console.WriteLine(string.Join(",", BiggerArr(startArray)));
            Console.WriteLine(string.Join(",", NewArr(startArray, 5)));

            int[] BiggerArr(int[] arr)
            {
                int[] temp = new int[arr.Length + 1];

                for (int i = 0; i < temp.Length - 1; i++)
                {
                    temp[i + 1] = arr[i];
                }
                return temp;
            }

            int[] NewArr(int[] array, int value)
            {
                int[] temp = BiggerArr(startArray);
                temp[0] = value;
                return temp;
            }
        }
        public static void Task8()
        {
            int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 1, 0, 5, 6 } };
            Console.WriteLine("Add Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == n)
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine($"Repeat in array: {count}");
        }
        public static void Task9()
        {
            int[,] arr = new int[,] { { 1, 2, 3, 4 },
                                      { 1, 0, 5, 6 },
                                      { 12, 24, 6, 6 },
                                      { 18, 33, 78, 100 } };

            Console.WriteLine("select the first line number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select the second line numberr");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var temp = arr[n, i];
                arr[n, i] = arr[t, i];
                arr[t, i] = temp;

            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void Task10()
        {
            int[,] arr = new int[,] { { 1, 2, 3, 4 },
                                      { 1, 0, 5, 6 },
                                      { 12, 24, 6, 6 },
                                      { 18, 33, 78, 100 } };

            Console.WriteLine("select Colum");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[j, n];

            }
            Console.WriteLine(sum);
        }
    }
}
