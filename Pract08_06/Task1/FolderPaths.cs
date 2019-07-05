using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pract08_06.Task1
{
    public class FolderPath
    {
        private const string Path = @"C:\Windows\System32";

        private string[] dirDirect;

        private string[] dirFile;

        private FileInfo fileInf;

        private int calculate;

        private long temp;

        public FolderPath()
        {
            this.dirDirect = Directory.GetDirectories(Path);
            this.dirFile = Directory.GetFiles(Path);
            this.fileInf = new FileInfo(Path);
            this.calculate = 0;
            this.temp = 0;
        }

        public void Calc()
        {
            foreach (var item in this.dirDirect)
            {
                FileInfo fileInf = new FileInfo(item);
                this.calculate++;
            }

            foreach (var item in this.dirFile)
            {
                FileInfo fileInf = new FileInfo(item);
                this.temp += fileInf.Length;
            }
            

            Console.WriteLine(this.calculate);
            Console.WriteLine(this.temp);

        }


    }
}
