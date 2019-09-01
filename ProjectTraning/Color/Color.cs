using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Color
{
    class ColorEnum
    {
        public void Execute()
        {
            string someText = GetText();

            ConsoleColor color = GetColor();

            Print(someText, color);
        }

        private  string GetText()
        {
            Console.WriteLine("Enter text:");

            var someText = Console.ReadLine();

            return someText;
        }

        private  ConsoleColor GetColor()
        {
            Console.WriteLine("Enter number of color from 0 till 15");

            var colorNumber = Int32.Parse(Console.ReadLine());

            ConsoleColor color = (ConsoleColor)colorNumber;

            return color;
        }

        private  void Print(string someText, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(someText);

            Console.ResetColor();
        }
    }
}

