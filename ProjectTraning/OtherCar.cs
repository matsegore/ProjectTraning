using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    public class OtherCar : Draw
    {
        public static int Result { get; set; }

        public static int Score { get; set; }

        private int CrashReport { get; set; }

        private int PositionReport { get; set; }

        public static int Life = 3;

        Border border = new Border();


        public void CarFallingLeft()
        {
            while (true)
            {
                this.CrashReport = 0;

                int temp = 1;

                this.PositionReport = 0;

                for (int i = 3; i < 23 + 4; i++)
                {
                    Thread.Sleep(100 / new GameLogic().Speed());

                    lock (locker)
                    {
                        if (i == 19 || i == 20 || i == 21 || i == 22)
                        {
                            temp = 2;
                        }

                        if(i == 3)
                        {
                            CreateElement(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 4)
                        {
                            CreateElement(border.SecondRoadLine - 6, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 8, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.SecondRoadLine - 6, i - 2);
                            CreateElement(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            CreateElement(border.SecondRoadLine - 6, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 8, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i == 6)
                        {
                            CreateElement(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            CreateElement(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            CreateElement(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            CreateElement(border.SecondRoadLine - 6, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 8, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i, CarValue);
                        }

                        else if (i > 6 & i < 23)
                        {
                            CreateElement(border.SecondRoadLine - 7, i, CarValue);
                            CreateElement(border.SecondRoadLine - 6, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 7, i - 1, CarValue);
                            CreateElement(border.SecondRoadLine - 8, i - 1, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 2);
                            CreateElement(border.SecondRoadLine - 7, i - 2, CarValue);
                            Clear(border.SecondRoadLine - 8, i - 2);
                            CreateElement(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            CreateElement(border.SecondRoadLine - 8, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        if (GameLogic.MyCarPosition != temp)
                        {
                            if (i == 23 )
                            {                               
                                CreateElement(border.SecondRoadLine - 6, i - 1, CarValue);
                                CreateElement(border.SecondRoadLine - 7, i - 1, CarValue);
                                CreateElement(border.SecondRoadLine - 8, i - 1, CarValue);
                                Clear(border.SecondRoadLine - 6, i - 2);
                                CreateElement(border.SecondRoadLine - 7, i - 2, CarValue);
                                Clear(border.SecondRoadLine - 8, i - 2);
                                CreateElement(border.SecondRoadLine - 6, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 7, i - 3);
                                CreateElement(border.SecondRoadLine - 8, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 6, i - 4);
                                Clear(border.SecondRoadLine - 8, i - 4);
                                temp = 2;
                            }

                            else if (i == 24)
                            {
                                Clear(border.SecondRoadLine - 6, i - 2);
                                CreateElement(border.SecondRoadLine - 7, i - 2, CarValue);
                                Clear(border.SecondRoadLine - 8, i - 2);
                                CreateElement(border.SecondRoadLine - 6, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 7, i - 3);
                                CreateElement(border.SecondRoadLine - 8, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 6, i - 4);
                                Clear(border.SecondRoadLine - 8, i - 4);
                            }

                            else if (i == 25)
                            {
                                CreateElement(border.SecondRoadLine - 6, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 7, i - 3);
                                CreateElement(border.SecondRoadLine - 8, i - 3, CarValue);
                                Clear(border.SecondRoadLine - 6, i - 4);
                                Clear(border.SecondRoadLine - 8, i - 4);
                            }

                            else if (i == 26)
                            {
                                Clear(border.SecondRoadLine - 6, i - 4);
                                Clear(border.SecondRoadLine - 8, i - 4);
                                
                                if(this.PositionReport != 1)
                                {
                                    OtherCar.Score += 5;
                                }
                            }
                        }

                                               
                        if (GameLogic.MyCarPosition == temp)
                        {
                            lock (locker)
                            {
                                this.PositionReport = 1;

                                if (i == 19 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 1;
                                }

                                else if (i == 20 && this.CrashReport != 1 && this.CrashReport != 3 && this.CrashReport != 4 
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 2;
                                }

                                else if (i == 21 && this.CrashReport != 2 && this.CrashReport != 1 && this.CrashReport != 4 
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 3;
                                }

                                else if (i == 22 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 1
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 4;
                                }

                                else if (i == 23 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4
                                    && this.CrashReport != 1 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 5;
                                }

                                else if (i == 24 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4
                                    && this.CrashReport != 5 && this.CrashReport != 1 && this.CrashReport != 7 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 6;
                                }

                                else if (i == 25 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 1 && this.CrashReport != 8)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 7;
                                }

                                else if (i == 26 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 
                                    && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 1)
                                {
                                    OtherCar.Life -= 1;
                                    this.CrashReport = 8;
                                }


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
                                    CreateElement(border.SecondRoadLine - 8, i - 2, CarValue);
                                    CreateElement(border.SecondRoadLine - 6, i - 2, CarValue);
                                    CreateElement(border.SecondRoadLine - 7, i - 3, CarValue);
                                }

                                if (i == 23)
                                {
                                    Clear(border.SecondRoadLine - 8, i - 4);
                                    Clear(border.SecondRoadLine - 6, i - 4);
                                    CreateElement(border.SecondRoadLine - 7, i - 3, CarValue);
                                }

                                if (i == 24)
                                {
                                    Clear(border.SecondRoadLine - 7, i - 2);
                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                    CreateElement(border.SecondRoadLine - 7, i - 3, CarValue);
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

                        CreateElement(40, 12, "GAME OVER");

                        CreateElement(38, 13, $"YOUR SCORE  { OtherCar.Score}");

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
                this.CrashReport = 0;

                int temp = 1;

                this.PositionReport = 0;

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
                            CreateElement(border.FirstRoadLine + 7, i, CarValue);

                        }

                        else if (i == 4)
                        {
                            CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 8, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i == 5)
                        {
                            Clear(border.FirstRoadLine + 6, i - 2);
                            CreateElement(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 8, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i == 6)
                        {
                            CreateElement(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            CreateElement(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            CreateElement(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 8, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i, CarValue);
                        }

                        else if (i > 6 && i < 23)
                        {
                            CreateElement(border.FirstRoadLine + 7, i, CarValue);
                            CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 7, i - 1, CarValue);
                            CreateElement(border.FirstRoadLine + 8, i - 1, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 2);
                            CreateElement(border.FirstRoadLine + 7, i - 2, CarValue);
                            Clear(border.FirstRoadLine + 8, i - 2);
                            CreateElement(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            CreateElement(border.FirstRoadLine + 8, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 6, i - 4);
                            Clear(border.FirstRoadLine + 8, i - 4);
                        }

                        if( GameLogic.MyCarPosition != temp)
                        {
                            if (i == 23)
                            {
                                CreateElement(border.FirstRoadLine + 6, i - 1, CarValue);
                                CreateElement(border.FirstRoadLine + 7, i - 1, CarValue);
                                CreateElement(border.FirstRoadLine + 8, i - 1, CarValue);
                                Clear(border.FirstRoadLine + 6, i - 2);
                                CreateElement(border.FirstRoadLine + 7, i - 2, CarValue);
                                Clear(border.FirstRoadLine + 8, i - 2);
                                CreateElement(border.FirstRoadLine + 6, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 7, i - 3);
                                CreateElement(border.FirstRoadLine + 8, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                Clear(border.FirstRoadLine + 8, i - 4);
                            }

                            else if (i == 24)
                            {
                                Clear(border.FirstRoadLine + 6, i - 2);
                                CreateElement(border.FirstRoadLine + 7, i - 2, CarValue);
                                Clear(border.FirstRoadLine + 8, i - 2);
                                CreateElement(border.FirstRoadLine + 6, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 7, i - 3);
                                CreateElement(border.FirstRoadLine + 8, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                Clear(border.FirstRoadLine + 8, i - 4);
                            }

                            else if (i == 25)
                            {
                                CreateElement(border.FirstRoadLine + 6, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 7, i - 3);
                                CreateElement(border.FirstRoadLine + 8, i - 3, CarValue);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                Clear(border.FirstRoadLine + 8, i - 4);
                            }

                            else if (i == 26)
                            {
                                Clear(border.FirstRoadLine + 6, i - 4);
                                Clear(border.FirstRoadLine + 8, i - 4);
                                if (this.PositionReport != 1)
                                {
                                    OtherCar.Score += 5;
                                }
                            }
                        }                       
                    }

                    if (GameLogic.MyCarPosition == temp)
                    {
                        lock (locker)
                        {
                            this.PositionReport = 1;

                            if (i == 19 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 &&
                                this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 1;
                            }

                            else if (i == 20 && this.CrashReport != 1 && this.CrashReport != 3 && this.CrashReport != 4 &&
                                this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 2;
                            }

                            else if (i == 21 && this.CrashReport != 2 && this.CrashReport != 1 && this.CrashReport != 4 &&
                                this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 3;
                            }

                            else if (i == 22 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 1
                                && this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 4;
                            }

                            else if (i == 23 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4
                                && this.CrashReport != 1 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 5;
                            }

                            else if (i == 24 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4
                                && this.CrashReport != 5 && this.CrashReport != 1 && this.CrashReport != 7 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 6;
                            }

                            else if (i == 25 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 &&
                                this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 1 && this.CrashReport != 8)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 7;
                            }

                            else if (i == 26 && this.CrashReport != 2 && this.CrashReport != 3 && this.CrashReport != 4 &&
                                this.CrashReport != 5 && this.CrashReport != 6 && this.CrashReport != 7 && this.CrashReport != 1)
                            {
                                OtherCar.Life -= 1;
                                this.CrashReport = 8;
                            }
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

                            else if(i == 20)
                            {
                                Clear(border.FirstRoadLine + 8, i - 1);
                                Clear(border.FirstRoadLine + 6, i - 1);
                                Clear(border.FirstRoadLine + 7, i - 2);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                            }

                            else if (i == 21)
                            {
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                            }

                            else if (i == 22)
                            {
                                Clear(border.FirstRoadLine + 7, i);
                                Clear(border.FirstRoadLine + 8, i - 1);
                                Clear(border.FirstRoadLine + 6, i - 1);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                                CreateElement(border.FirstRoadLine + 8, i - 2, CarValue);
                                CreateElement(border.FirstRoadLine + 6, i - 2, CarValue);
                                CreateElement(border.FirstRoadLine + 7, i - 3, CarValue);
                            }

                            else if (i == 23)
                            {
                                Clear(border.FirstRoadLine + 8, i - 4);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                CreateElement(border.FirstRoadLine + 7, i - 3, CarValue);

                            }

                            else if (i == 24)
                            {
                                Clear(border.FirstRoadLine + 7, i - 2);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                                CreateElement(border.FirstRoadLine + 7, i - 3, CarValue);
                            }

                            else if (i == 25)
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

                        CreateElement(40, 12, "GAME OVER");

                        CreateElement(38, 13, $"YOUR SCORE  { OtherCar.Score}");

                        OtherCar.Result = 1;

                        Thread.CurrentThread.Abort();
                    }
                }
            }
        }
    }
}


