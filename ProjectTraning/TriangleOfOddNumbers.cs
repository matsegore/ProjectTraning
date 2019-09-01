using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class TriangleOfOddNumbers
    {
        public void Execute()
        {

            int i, j, rows;

            Console.Write("Input number of rows : ");

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {                
                    for (j = 1; j <= i; j++)
                    {
                    if( i % 2 == 1)
                    Console.Write(" {0} ", i);
                    }
              
                Console.Write("\n");
            }
        }
    }
}