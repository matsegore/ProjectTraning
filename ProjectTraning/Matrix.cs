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
        public static object locker = new object();

        private Random random;

        private int Height;

        private int Width;

        public Matrix()
        {
            this.random = new Random();

            this.Width = Console.WindowWidth;

            this.Height = Console.WindowHeight;
        }

        public void NewMatrics()
        {

            while (true)
            {
                int rand = random.Next(0, this.Width);
                int randV = random.Next(3, 20);
                Console.CursorVisible = false;
                
                for (int i = 0, y = 0; i < this.Height + randV + 1; i++)
                {
                    //Thread.Sleep(rand);

                    lock (locker)
                    {
                        if (i < this.Height)
                        {
                            Console.SetCursorPosition(rand, i);
                            Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                        }

                        if (i >= randV)
                        {
                            Console.SetCursorPosition(rand, y);
                            Console.WriteLine(" ");
                            y++;
                        }

                        if (i > 0)
                        {
                            var prev = 0;
                            var next = 0;
                            while (prev <= i && prev < randV && i <= this.Height)
                            {

                                Console.SetCursorPosition(rand, i - prev);
                                Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                                prev++;

                                if (prev > i)
                                {
                                    break;
                                }
                            }
                            if (i >= this.Height)
                            {
                                while (y + next <= this.Height)
                                {

                                    Console.SetCursorPosition(rand, y + next);
                                    Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                                    next++;
                                }
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
