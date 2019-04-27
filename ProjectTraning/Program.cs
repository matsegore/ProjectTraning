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
            Task4();
        }
        public static void Task4()
        {
            var arrayNumbers = new char[10] { '0','1','2','3','4','5','6','7','8','9'};
            var arraySymbols = new char [11] {':','+','/','.','^','@','"','!','%','#','$'};
            Console.WriteLine("Add size of array");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            var newArray = new char[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Add number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                    while ((i<=10) && (array[i] != arrayNumbers[j]))
                    {
                        if (j <= 10)
                        {
                            newArray[i] = arraySymbols[j];
                            break;
                        }
                        else
                        {
                            newArray[i] = arraySymbols[11];
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Result");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

        }
    }
}

