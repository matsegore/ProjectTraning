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
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
        }

        public static void Task1()
        {
            Console.WriteLine("Add string: ");

            string a = Console.ReadLine();
            
            var newString = new HashSet<char>(a);

            Console.Write("New String after removing duplicates: ");

            foreach (char c in newString)
                Console.Write(c);

            Console.WriteLine();
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

        public static void Task6()
        {

            string text = "One?? Or two? Or one?";

            Console.WriteLine(text);

            Console.Write("Add index: ");

            var index = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            string[] array = text.Split(' ');

            Console.WriteLine($"Word with index {index} is \"{array[index]}\".");

            string word = array[index];

            string letter = word.Substring(0, 1);

            Console.WriteLine($"First symbol of \"{word}\" is \"{letter}\".");

        }



        public static void Task7()
        {
            Console.WriteLine("Add text:");

            var text = Console.ReadLine();

            string[] arrayOfText = text.Split(' ');

            int arrayLenght = arrayOfText.Length;

            string temp = string.Empty;

            for (int i = 0, j = arrayLenght - 1; i < j & j < arrayLenght; i++, j--)
            {
                temp = arrayOfText[i];

                arrayOfText[i] = arrayOfText[j];

                arrayOfText[j] = temp;
            }

            Console.WriteLine("Swapped text:");

            Console.WriteLine(string.Join(" ", arrayOfText));

        }



        public static void Task8()
        {
            Console.WriteLine("Enter text:");

            var text = Console.ReadLine();

            string[] arrayOfText = text.Split(' ');

            int maxSize = arrayOfText[0].Length;

            string maxSizeWord = string.Empty;

            int minSize = arrayOfText[0].Length;

            string minSizeWord = string.Empty;

            for (int i = 0; i < arrayOfText.Length; i++)
            {
                if (maxSize < arrayOfText[i].Length)
                {
                    maxSize = arrayOfText[i].Length;

                    maxSizeWord = arrayOfText[i];
                }

                if (minSize > arrayOfText[i].Length)
                {
                    minSize = arrayOfText[i].Length;

                    minSizeWord = arrayOfText[i];
                }
            }
            Console.WriteLine($"Longest word: '{maxSizeWord}' Lenght: {maxSize} Shortest word: '{minSizeWord}' Lenght {minSize}");
        }

    }
}
