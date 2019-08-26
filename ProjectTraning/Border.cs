using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Border
    {
        int roadHeight = 20;

        int roadWidth = 20;

        public void NewMatrics()
        {
            while (true)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Thread.Sleep(200);
                    for (int i = 0; i < this.roadHeight + 1; i++)
                    {
                        Console.CursorVisible = false;
                       
                        if (i % 4 != 0)
                        {
                            Console.SetCursorPosition(30, i+j);
                            Console.WriteLine("0");
                            Console.SetCursorPosition(60, i+j);
                            Console.WriteLine("0");
                        }

                        else if (i % 4 == 0)
                        {
                            Console.SetCursorPosition(30, i + j);
                            Console.WriteLine(" ");
                            Console.SetCursorPosition(60, i + j);
                            Console.WriteLine(" ");
                        }
                    }

                }
            }
        }
    }
}

