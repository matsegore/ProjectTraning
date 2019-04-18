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
            //Task3();
            //Task4();
            Task5();
        }
        public static void Task2()
        {
            Console.WriteLine("Add string: ");
            string a = Console.ReadLine();
            Console.WriteLine("Add symbol to count: ");
            char b = Convert.ToChar(Console.Read());
            int count = 0;
            for (int i=0; i<a.Length; i++)
            {
                if (b == a[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of simbols: {count}");
        }
        public static void Task3()
        {
            Console.WriteLine("Add string: ");
            string firstStr = Console.ReadLine();
            Console.WriteLine("Add 2nd string: ");
            string secondStr = Console.ReadLine();
            Console.WriteLine("Add pos for adding second string in first string: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            string modified = firstStr.Insert(pos, secondStr);
            Console.WriteLine($"Modified string: {modified}");
        }

        public static void Task4()
        {
            Console.WriteLine("Add string: ");
            string a = Console.ReadLine();         
            char b = '?';
            int counter = 0;
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                
                if ( b == a[i])
                {
                    counter++;
                }
                else if (counter==1)
                {
                    if (a[i] == ' ')
                    {
                        continue;
                    }
                }
                result += a[i];
            }
            Console.WriteLine($"Fixed string:{result}");
        }

        public static void Task5()
        {
            Console.WriteLine("Add string: ");
            string a = Console.ReadLine();
            string result = "";
            string space = " ";
            string[] words = a.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i]!= string.Empty)
                { 
                result += words[i] + " ";
                }
            }
            Console.WriteLine(result);
        }

    }
}
