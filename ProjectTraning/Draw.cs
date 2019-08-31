using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProjectTraning
{
    public class Draw
    {
        public static object locker = new object();

        public string CarValue { get; set; }

        public string FieldAndBorderdValue { get; set; }

        public string BorderValue { get; set; }

        public Draw()
        {
            this.CarValue = "x";
            this.FieldAndBorderdValue = "O";
        }

        public void CreateElement(int x, int y, string value)
        {
            lock (locker)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(value);
            }
        }

        public void Clear(int x, int y)
        {
            lock (locker)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ");
            }
        }
    }
}

