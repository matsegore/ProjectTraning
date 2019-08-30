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

        public static int Score { get; set; }

        public static int Life = 3;

        Border border = new Border();


        public void CarFallingLeft()
        {
            while (true)
            {


                //if (OtherCar.Result == 1)
                //{
                //    break;
                //}

                int temp = 1;

                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100);

                    lock (locker)
                    {
                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 2;
                        }

                        if (i == 3)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 4)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 6)
                        {
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i > 6 && i < 23)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, i, CarValue);
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 23 && temp == 1)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                            temp = 2;
                        }

                        else if (i == 24 && temp == 1)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 25 && temp == 1)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 26 && temp == 2)
                        {
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                            OtherCar.Score += 5;
                        }
                       

                        if (GameLogic.MyCarPosition == temp && i == 19)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 19)
                                    {
                                        Clear(border.SecondRoadLine - 7, i - 1);
                                        Clear(border.SecondRoadLine - 6, i - 1);
                                        Clear(border.SecondRoadLine - 8, i - 1);
                                        Clear(border.SecondRoadLine - 7, i - 2);
                                        Clear(border.SecondRoadLine - 8, i - 3);
                                        Clear(border.SecondRoadLine - 6, i - 3);
                                        OtherCar.Life -= 1;
                                    }
                                }
                            }
                        }

                        if (GameLogic.MyCarPosition == temp && i == 20)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 20)
                                    {
                                        Clear(border.SecondRoadLine - 8, i - 1);
                                        Clear(border.SecondRoadLine - 6, i - 1);
                                        Clear(border.SecondRoadLine - 7, i - 2);
                                        Clear(border.SecondRoadLine - 8, i - 3);
                                        Clear(border.SecondRoadLine - 6, i - 3);
                                    }
                                }
                            }
                        }

                        if (GameLogic.MyCarPosition == temp && i == 21)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 21)
                                    {

                                        Clear(border.SecondRoadLine - 8, i - 3);
                                        Clear(border.SecondRoadLine - 6, i - 3);

                                    }
                                }
                            }
                        }

                        if (GameLogic.MyCarPosition == temp && i == 22)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 22)
                                    {
                                        Clear(border.SecondRoadLine - 7, i);
                                        Clear(border.SecondRoadLine - 8, i - 1);
                                        Clear(border.SecondRoadLine - 6, i - 1);
                                        Clear(border.SecondRoadLine - 8, i - 3);
                                        Clear(border.SecondRoadLine - 6, i - 3);
                                        DrowMyCar(border.SecondRoadLine - 8, i - 2, CarValue);
                                        DrowMyCar(border.SecondRoadLine - 6, i - 2, CarValue);
                                        DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                    }
                                }
                            }
                        }

                        if (GameLogic.MyCarPosition == temp && i == 23)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 23)
                                    {
                                        DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                    }
                                }
                            }
                        }

                        if (GameLogic.MyCarPosition == temp && i == 24)
                        {
                            if (OtherCar.Life > 0)
                            {
                                //Thread.Sleep(750);


                                lock (locker)
                                {
                                    if (i == 24)
                                    {
                                        Clear(border.SecondRoadLine - 7, i - 2);
                                        Clear(border.SecondRoadLine - 8, i - 3);
                                        Clear(border.SecondRoadLine - 6, i - 3);
                                        DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                    }
                                }
                            }


                        }
                        lock (locker)
                        {
                            if (OtherCar.Life == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                lock (locker)
                {
                    if (OtherCar.Life == 0)
                    {

                        Console.Clear();

                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine($"GAME OVER");

                        Console.SetCursorPosition(38, 13);
                        Console.WriteLine($"YOUR SCORE  { OtherCar.Score}");

                        OtherCar.Result = 1;

                        Thread.CurrentThread.Abort();
                    }
                }
            }
        }

        public void CarFallingRight()
        {
            while (true)
            {
                int temp = 1;
                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100);

                    lock (locker)
                    {
                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 3;
                        }

                        if (i == 3)
                        {
                            DrowMyCar(border.FirstRoadLine + 7, i, CarValue);

                        }

                        else if (i == 4)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i, CarValue);

                        }

                        else if (i == 6)
                        {
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i > 6 && i < 23)
                        {
                            DrowMyCar(border.FirstRoadLine + 7, i, CarValue);
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 23 && temp!=3)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrowMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);

                        }

                        else if (i == 24 && temp != 3)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrowMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 25 && temp != 3)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 26 && temp != 3)
                        {
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                            OtherCar.Score += 5;
                        }

                    }

                    if (GameLogic.MyCarPosition == temp && i == 19)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 19)
                                {
                                    Clear(border.FirstRoadLine + 7, i - 1);
                                    Clear(border.FirstRoadLine + 6, i - 1);
                                    Clear(border.FirstRoadLine + 8, i - 1);
                                    Clear(border.FirstRoadLine + 7, i - 2);
                                    Clear(border.FirstRoadLine + 8, i - 3);
                                    Clear(border.FirstRoadLine + 6, i - 3);
                                    OtherCar.Life -= 1;
                                }
                            }
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && i == 20)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 20)
                                {
                                    Clear(border.FirstRoadLine + 8, i - 1);
                                    Clear(border.FirstRoadLine + 6, i - 1);
                                    Clear(border.FirstRoadLine + 7, i - 2);
                                    Clear(border.FirstRoadLine + 8, i - 3);
                                    Clear(border.FirstRoadLine + 6, i - 3);
                                }
                            }
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && i == 21)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 21)
                                {

                                    Clear(border.FirstRoadLine + 8, i - 3);
                                    Clear(border.FirstRoadLine + 6, i - 3);

                                }
                            }
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && i == 22)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 22)
                                {
                                    Clear(border.FirstRoadLine + 7, i);                                  
                                    Clear(border.FirstRoadLine + 8, i-1);
                                    Clear(border.FirstRoadLine + 6, i - 1);
                                    Clear(border.FirstRoadLine + 8, i - 3);
                                    Clear(border.FirstRoadLine + 6, i - 3);
                                    DrowMyCar(border.FirstRoadLine + 8, i - 2, CarValue);
                                    DrowMyCar(border.FirstRoadLine + 6, i - 2, CarValue);
                                    DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);
                                }
                            }
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && i == 23)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 23)
                                {
                                    DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);
                                }
                            }
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && i == 24)
                    {
                        if (OtherCar.Life > 0)
                        {
                            //Thread.Sleep(750);


                            lock (locker)
                            {
                                if (i == 24)
                                {
                                    Clear(border.FirstRoadLine + 7, i-2);
                                    Clear(border.FirstRoadLine + 8, i - 3);
                                    Clear(border.FirstRoadLine + 6, i - 3);
                                    DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);
                                }
                            }
                        }


                    }

                    lock (locker)
                    {
                        if (OtherCar.Life == 0)
                        {
                            break;
                        }
                    }

                }
                lock (locker)
                {
                    if (OtherCar.Life == 0)
                    {

                        Console.Clear();

                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine($"GAME OVER");

                        Console.SetCursorPosition(38, 13);
                        Console.WriteLine($"YOUR SCORE  { OtherCar.Score}");

                        OtherCar.Result = 1;

                        Thread.CurrentThread.Abort();
                    }
                }
            }
        }
    }
}


