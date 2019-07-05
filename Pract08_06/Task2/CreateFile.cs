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
        private const string Path = @"C:\Temp\userText.txt";

        static FileInfo file = new FileInfo(Path);

        static FileStream files = file.Create();

        StreamWriter fs = new StreamWriter(files);
    }
}
