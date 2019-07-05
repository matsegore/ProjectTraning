using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pract08_06.Task2
{
    class CreateFile
    {
        public void CreateTextFile()
        {
            var path = @"C:\Temp\";
            var file = "Text.txt";
            Console.WriteLine("Add text for adding to the text file.");
            var text = Console.ReadLine();

            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder exists.");
                File.WriteAllText(path + file, text);
                Console.WriteLine("File created.");
            }
            else
            {
                Console.WriteLine("Folder created.");
                Directory.CreateDirectory(path);
                File.WriteAllText(path + file, text);
                Console.WriteLine("File created.");
            }
        }
    }
}
