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
        static void Task1()
        {
            Console.Write("Enter the number of elements in the array: ");
            int arrayLangth = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLangth];
            Console.WriteLine("Fill array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Add number: ", i+1);
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
    }
}
