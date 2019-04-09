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
            //Task5();
            //Task5t();
            //Task6();
        }
        static void Task1()
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

    }
}
