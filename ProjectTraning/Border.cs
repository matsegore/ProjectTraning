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

        int borderWidth = 10;

        public void NewMatrics()
        {
            while (true)
            {
                Console.SetWindowSize(20, 20);

                for (int i = 0, y=0, k=0;  i < this.borderHeight+3; i++)
                {
                    Thread.Sleep(50);
                    //for (int j = 0, z = 0; j < this.borderWidth+3; j++)
                    //{
                    //    if (i % 1 == 0)
                    //    {
                    //        Console.SetCursorPosition(0, i);
                    //        Console.WriteLine("0");
                    //        Console.SetCursorPosition(5, i);
                    //        Console.WriteLine("0");
                            
                    //    }
                    //}
                    if (i % 4!=0)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("0");                  
                        Console.SetCursorPosition(5, i);
                        Console.WriteLine("0");
                    }

                    else if (i % 4 == 0)
                    {
                        Console.WriteLine(" ");
                    }
                }

                }
            }
        }
    }

