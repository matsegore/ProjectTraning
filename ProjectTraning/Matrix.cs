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

        public static Random random;

        private int Height;

        private int Width;

        public Matrix()
        {
            random = new Random();

            this.Width = Console.WindowWidth;

            this.Height = Console.WindowHeight;
        }

        public void NewMatrics()
        {

            while (true)
            {
                int rand = random.Next(0, this.Width);

                int randV = random.Next(1, 20);


                Console.CursorVisible = false;


                for (int i = 0, y = 0; i < this.Height + randV + 1; i++)
                {

                    lock (locker)
                    {
                        if (i < this.Height)
                        {
                            Console.SetCursorPosition(rand, i);
                            Console.WriteLine(Convert.ToChar(random.Next(50, 100)));
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                    }

                    lock (locker)
                    {
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
                            lock (locker)
                            {
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
                            lock (locker)
                            {
                                if (i >= randV)
                                {
                                    Console.SetCursorPosition(rand, y);
                                    Console.WriteLine(" ");
                                    y++;

                                }
                            }
                        }


                    }
                }
            }
        }
    }
}

