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
        int borderHeight = 20;

        int borderWidth = 20;

        public void NewMatrics()
        {
            while (true)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Thread.Sleep(200);
                    for (int i = 0; i < this.borderHeight + 3; i++)
                    {
                        Console.CursorVisible = true;

                        
                        if (i % 4 != 0)
                        {
                            Console.SetCursorPosition(0, i+j);
                            Console.WriteLine("0");
                            Console.SetCursorPosition(borderWidth, i+j);
                            Console.WriteLine("0");
                        }

                        else if (i % 4 == 0)
                        {
                            Console.WriteLine(" ");
                            Console.SetCursorPosition(borderWidth, i + j);
                            Console.WriteLine(" ");
                        }
                    }

                }
            }
        }
    }
}

