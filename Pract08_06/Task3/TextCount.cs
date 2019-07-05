using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pract08_06.Task3
{
    class TextCount
    {
        public void CountText()
        {
            var Path = @"C:\FolderForCurces\Text.txt";
            var file = File.ReadAllText(Path);
            var counter = 0;

            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] != ' ' && file[i] != '\n')
                {
                    counter++;
                }
                else
                    continue;
            }
            Console.WriteLine("Number of spaces:" + counter);
            Console.WriteLine("Number of elements:" + file.Length);
        }
    }
}
