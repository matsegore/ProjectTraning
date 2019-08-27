using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Field
    {
        public int Height;

        public int Width;

        public Field()
        {
            this.Height = 28;

            this.Width = 90;
        }

        public void BordersOfField()
        {
            lock (Draw.locker)
            {
                for (int i = 0; i <= this.Width; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("*");
                }

                for (int i = 0; i <= this.Width; i++)
                {
                    Console.SetCursorPosition(i, this.Height);
                    Console.Write("*");
                }

                for (int i = 0; i <= this.Height; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("#");
                }

                for (int i = 0; i <= this.Height; i++)
                {
                    Console.SetCursorPosition(this.Width, i);
                    Console.WriteLine("#");
                }
            }
        }
    }

}


