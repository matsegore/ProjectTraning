using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class Matrix
    {

        private Random random;

        private int Height;

        private int Width;

        public Matrix()
        {
            this.random = new Random();

            this.Width = Console.WindowWidth;

            this.Height = Console.WindowHeight;
        }

        public void MatrixExecute()
        {
            var t = new Thread(NewMatrics);
            t.Start();

        }

        public void NewMatrics()
        {
            while (true)
            {
                for (int i = 0, y = 0, z = 0; i < this.Height + 10; i++)
                {

                    if (i < this.Height)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                    }

                    if (i >= 10)
                    {
                        Console.SetCursorPosition(0, y);
                        Console.WriteLine(" ");
                        y++;
                    }
                    Thread.Sleep(500);
                    if (i > 0)
                    {
                        var prev = 0;
                        var next = 0;
                        while (prev <= i && prev < 10 && i <= this.Height)
                        {

                            Console.SetCursorPosition(0, i - prev);
                            Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                            prev++;

                            if (prev > i)
                            {
                                break;
                            }
                        }
                        if (i >= this.Height)
                        {
                            while (y + next <= this.Height - 1)
                            {

                                Console.SetCursorPosition(0, y + next + 1);
                                Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                                next++;
                            }
                        }
                    }

                }
            }
        }

        public void TypeOfConsoleColor()
        {


        }

        public void RandomValues(int i)
        {
            while (true)
            {
                i = Convert.ToChar(random.Next(50, 100));
            }
        }


        public void Cursor()
        {
            Console.SetCursorPosition(this.random.Next(50, 100), this.random.Next(1, 100));
        }


    }
}
