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

        private int CrashReportLeft { get; set; }

        private int CrashReportRight { get; set; }

        public static int Life = 3;

        Border border = new Border();


        public void CarFallingLeft()
        {
            while (true)
            {
                this.CrashReportLeft = 0;
                int temp = 1;

                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100/new GameLogic().Speed());
                    
                    lock (locker)
                    {
                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 2;
                        }

                        if (i == 3)
                        {
                            DrawMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 4)
                        {
                            DrawMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrawMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrawMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 6)
                        {
                            DrawMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrawMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrawMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrawMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i > 6 & i < 23)
                        {
                            DrawMyCar(border.SecondRoadLine - 7, i, CarValue);
                            DrawMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrawMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrawMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrawMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 23 && GameLogic.MyCarPosition != temp)
                        {
                            DrawMyCar(border.SecondRoadLine - 6, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 7, i - 1, CarValue);
                            DrawMyCar(border.SecondRoadLine - 8, i - 1, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrawMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrawMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrawMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                            temp = 2;
                        }

                        else if (i == 24 && GameLogic.MyCarPosition != temp)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            DrawMyCar(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            DrawMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrawMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 25 && GameLogic.MyCarPosition != temp)
                        {
                            DrawMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrawMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        else if (i == 26 && GameLogic.MyCarPosition != temp)
                        {
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                            OtherCar.Score += 5;
                        }


                        if (GameLogic.MyCarPosition == temp && OtherCar.Life > 0)
                        {
                            if (i == 19 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4 &&
                           this.CrashReportLeft != 5 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 1;
                            }

                            if (i == 20 && this.CrashReportLeft != 1 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4 &&
                                this.CrashReportLeft != 5 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 2;
                            }

                            if (i == 21 && this.CrashReportLeft != 2 && this.CrashReportLeft != 1 && this.CrashReportLeft != 4 &&
                                this.CrashReportLeft != 5 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 3;
                            }

                            if (i == 22 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 1
                                && this.CrashReportLeft != 5 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 4;
                            }

                            if (i == 23 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4
                                && this.CrashReportLeft != 1 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 5;
                            }

                            if (i == 24 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4
                                && this.CrashReportLeft != 5 && this.CrashReportLeft != 1 && this.CrashReportLeft != 7 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 6;
                            }

                            if (i == 25 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4 &&
                                this.CrashReportLeft != 6 && this.CrashReportLeft != 1 && this.CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 7;
                            }

                            if (i == 26 && this.CrashReportLeft != 2 && this.CrashReportLeft != 3 && this.CrashReportLeft != 4 &&
                                this.CrashReportLeft != 5 && this.CrashReportLeft != 6 && this.CrashReportLeft != 7 && this.CrashReportLeft != 1)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReportLeft = 8;
                            }

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
                                }

                                if (i == 20)
                                {
                                    Clear(border.SecondRoadLine - 8, i - 1);
                                    Clear(border.SecondRoadLine - 6, i - 1);
                                    Clear(border.SecondRoadLine - 7, i - 2);
                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                }

                                if (i == 21)
                                {

                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                }

                                if (i == 22)
                                {

                                    Clear(border.SecondRoadLine - 7, i);
                                    Clear(border.SecondRoadLine - 8, i - 1);
                                    Clear(border.SecondRoadLine - 6, i - 1);
                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                    DrawMyCar(border.SecondRoadLine - 8, i - 2, CarValue);
                                    DrawMyCar(border.SecondRoadLine - 6, i - 2, CarValue);
                                    DrawMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                }

                                if (i == 23)
                                {
                                    Clear(border.SecondRoadLine - 8, i - 4);
                                    Clear(border.SecondRoadLine - 6, i - 4);
                                    DrawMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                }

                                if (i == 24)
                                {
                                    Clear(border.SecondRoadLine - 7, i - 2);
                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                    DrawMyCar(border.SecondRoadLine - 7, i - 3, CarValue);
                                }

                                if (i == 25)
                                {
                                    Clear(border.SecondRoadLine - 7, i - 3);
                                    Clear(border.SecondRoadLine - 8, i - 4);
                                    Clear(border.SecondRoadLine - 6, i - 4);
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
                this.CrashReportRight = 0;
                int temp = 1;
                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100 / new GameLogic().Speed());

                    lock (locker)
                    {
                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 3;
                        }

                        if (i == 3)
                        {
                            DrawMyCar(border.FirstRoadLine + 7, i, CarValue);

                        }

                        else if (i == 4)
                        {
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrawMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i == 6)
                        {
                            DrawMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrawMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrawMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i > 6 && i < 23)
                        {
                            DrawMyCar(border.FirstRoadLine + 7, i, CarValue);
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrawMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrawMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrawMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 23 && GameLogic.MyCarPosition != temp)
                        {
                            DrawMyCar(border.FirstRoadLine + 6, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 7, i - 1, CarValue);
                            DrawMyCar(border.FirstRoadLine + 8, i - 1, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrawMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrawMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrawMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);

                        }

                        else if (i == 24 && GameLogic.MyCarPosition != temp)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            DrawMyCar(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            DrawMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrawMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 25 && GameLogic.MyCarPosition != temp)
                        {
                            DrawMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrawMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        else if (i == 26 && GameLogic.MyCarPosition != temp)
                        {
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                            OtherCar.Score += 5;
                        }
                    }

                    if (GameLogic.MyCarPosition == temp && Life > 0)
                    {
                        if (i == 19 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 4 &&
                            this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 1;
                        }

                        if (i == 20 && this.CrashReportRight != 1 && this.CrashReportRight != 3 && this.CrashReportRight != 4 &&
                            this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 2;
                        }

                        if (i == 21 && this.CrashReportRight != 2 && this.CrashReportRight != 1 && this.CrashReportRight != 4 &&
                            this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 3;
                        }

                        if (i == 22 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 1
                            && this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 4;
                        }

                        if (i == 23 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 4
                            && this.CrashReportRight != 1 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 5;
                        }

                        if (i == 24 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 4
                            && this.CrashReportRight != 5 && this.CrashReportRight != 1 && this.CrashReportRight != 7 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 6;
                        }

                        if (i == 25 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 4 &&
                            this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 1 && this.CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 7;
                        }

                        if (i == 26 && this.CrashReportRight != 2 && this.CrashReportRight != 3 && this.CrashReportRight != 4 &&
                            this.CrashReportRight != 5 && this.CrashReportRight != 6 && this.CrashReportRight != 7 && this.CrashReportRight != 1)
                        {
                            OtherCar.Life -= 1;
                            this.CrashReportRight = 8;
                        }

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
                            }

                            if (i == 20)
                            {
                                Clear(border.FirstRoadLine + 8, i - 1);
                                Clear(border.FirstRoadLine + 6, i - 1);
                                Clear(border.FirstRoadLine + 7, i - 2);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                            }

                            if (i == 21)
                            {
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                            }

                            if (i == 22)
                            {
                                Clear(border.FirstRoadLine + 7, i);
                                Clear(border.FirstRoadLine + 8, i - 1);
                                Clear(border.FirstRoadLine + 6, i - 1);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                                DrawMyCar(border.FirstRoadLine + 8, i - 2, CarValue);
                                DrawMyCar(border.FirstRoadLine + 6, i - 2, CarValue);
                                DrawMyCar(border.FirstRoadLine + 7, i - 3, CarValue);
                            }

                            if (i == 23)
                            {
                                Clear(border.FirstRoadLine + 8, i - 4);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                DrawMyCar(border.FirstRoadLine + 7, i - 3, CarValue);

                            }

                            if (i == 24)
                            {
                                Clear(border.FirstRoadLine + 7, i - 2);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                                DrawMyCar(border.FirstRoadLine + 7, i - 3, CarValue);
                            }

                            if (i == 25)
                            {
                                Clear(border.FirstRoadLine + 7, i - 3);
                                Clear(border.FirstRoadLine + 8, i - 4);
                                Clear(border.FirstRoadLine + 6, i - 4);
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


