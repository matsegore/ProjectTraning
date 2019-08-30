using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProjectTraning
{
    class Draw
    {
        public static object locker = new object();

        public string CarValue { get; set; }

        public Draw()
        {
            this.CarValue = "x";
        }

        public void DrowMyCar(int x, int y, string value)
        {
            lock (locker)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(value);
            }
        }

        public void Clear(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
    }
}

