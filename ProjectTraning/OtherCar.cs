using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class OtherCar : Draw
    {
        public static int Result { get; set; }

        Border border = new Border();

        public void CarFallingRight()
        {
            while (true)
            {
                if (OtherCar.Result == 1)
                {
                    break;
                }
                int temp = 1;
                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100);

                    lock (locker)
                    {
                        if (i == 3)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                        }

                        else if (i == 4)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                        }

                        else if (i == 5)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                        }

                        else if (i == 6)
                        {
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                        }

                        else if (i > 6 && i < 23)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 23)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                            temp = 2;
                        }

                        else if (i == 24)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 25)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 26)
                        {
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 2;
                        }

                    }

                    if (GameLogic.MyCarPosition == temp || OtherCar.Result == 1)
                    {
                        break;
                    }
                }
                lock (locker)
                {
                    if (GameLogic.MyCarPosition == temp || OtherCar.Result == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("GAME OVER");
                        OtherCar.Result = 1;
                        break;
                    }
                }
            }
        }

        public void CarFallingLeft()
        {
            while (true)
            {
                int temp = 1;
                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100);

                    lock (locker)
                    {
                        if (i == 3)
                        {
                            DrowMyCar(border.FirstRoadLine + 7, i, "+");

                        }

                        else if (i == 4)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i, "+");
                        }

                        else if (i == 5)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, "+");
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i, "+");

                        }

                        else if (i == 6)
                        {
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, "+");
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, "+");
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, "+");
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i, "+");
                        }

                        else if (i > 6 && i < 23)
                        {
                            DrowMyCar(border.FirstRoadLine + 7, i, "+");
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, "+");
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, "+");
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, "+");
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, "+");
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 23)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, "+");
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, "+");
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, "+");
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, "+");
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, "+");
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);

                        }

                        else if (i == 24)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, "+");
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, "+");
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, "+");
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 25)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, "+");
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, "+");
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 26)
                        {
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 3;
                        }
                    }

                    if (GameLogic.MyCarPosition == temp || OtherCar.Result == 1)
                    {
                        break;
                    }

                }
                lock (locker)
                {
                    if (GameLogic.MyCarPosition == temp || OtherCar.Result == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("GAME OVER");
                        OtherCar.Result = 1;
                        break;
                    }
                }
            }
        }
    }
}

