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
                CrashReportLeft = 0;
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

                        else if (i > 6 & i < 23)
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

                        else if (i == 23 && GameLogic.MyCarPosition != temp)
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

                        else if (i == 24 && GameLogic.MyCarPosition != temp)
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

                        else if (i == 25 && GameLogic.MyCarPosition != temp)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, CarValue);
                            Clear(border.SecondRoadLine - 7, i - 3);
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, CarValue);
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
                            if (i == 19 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 4 &&
                           CrashReportLeft != 5 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 1;

                            }

                            if (i == 20 && CrashReportLeft != 1 && CrashReportLeft != 3 && CrashReportLeft != 4 &&
                                CrashReportLeft != 5 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 2;

                            }

                            if (i == 21 && CrashReportLeft != 2 && CrashReportLeft != 1 && CrashReportLeft != 4 &&
                                CrashReportLeft != 5 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 3;

                            }

                            if (i == 22 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 1
                                && CrashReportLeft != 5 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 4;

                            }

                            if (i == 23 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 4
                                && CrashReportLeft != 1 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 5;

                            }

                            if (i == 24 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 4
                                && CrashReportLeft != 5 && CrashReportLeft != 1 && CrashReportLeft != 7 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 6;

                            }

                            if (i == 25 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 4 &&
                                CrashReportLeft != 6 && CrashReportLeft != 1 && CrashReportLeft != 8)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 7;

                            }

                            if (i == 26 && CrashReportLeft != 2 && CrashReportLeft != 3 && CrashReportLeft != 4 &&
                                CrashReportLeft != 5 && CrashReportLeft != 6 && CrashReportLeft != 7 && CrashReportLeft != 1)
                            {
                                OtherCar.Life -= 1;
                                CrashReportLeft = 8;
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
                                    DrowMyCar(border.SecondRoadLine - 8, i - 2, CarValue);
                                    DrowMyCar(border.SecondRoadLine - 6, i - 2, CarValue);
                                    DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);

                                }

                                if (i == 23)
                                {

                                    Clear(border.SecondRoadLine - 8, i - 4);
                                    Clear(border.SecondRoadLine - 6, i - 4);
                                    DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);

                                }


                                if (i == 24)
                                {

                                    Clear(border.SecondRoadLine - 7, i - 2);
                                    Clear(border.SecondRoadLine - 8, i - 3);
                                    Clear(border.SecondRoadLine - 6, i - 3);
                                    DrowMyCar(border.SecondRoadLine - 7, i - 3, CarValue);

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
                CrashReportRight = 0;
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

                        else if (i == 23 && GameLogic.MyCarPosition != temp)
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

                        else if (i == 24 && GameLogic.MyCarPosition != temp)
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

                        else if (i == 25 && GameLogic.MyCarPosition != temp)
                        {
                            DrowMyCar(border.FirstRoadLine + 6, i - 3, CarValue);
                            Clear(border.FirstRoadLine + 7, i - 3);
                            DrowMyCar(border.FirstRoadLine + 8, i - 3, CarValue);
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
                        
                        if (i == 19 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 4 &&
                            CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 1;
                           
                        }

                        if (i == 20 && CrashReportRight != 1 && CrashReportRight != 3 && CrashReportRight != 4 &&
                            CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 2;
                            
                        }

                        if (i == 21 && CrashReportRight != 2 && CrashReportRight != 1 && CrashReportRight != 4 &&
                            CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 3;
                            
                        }

                        if (i == 22 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 1 
                            && CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 4;
                           
                        }

                        if (i == 23 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 4 
                            && CrashReportRight != 1 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 5;
                            
                        }

                        if (i == 24 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 4
                            && CrashReportRight != 5 && CrashReportRight != 1 && CrashReportRight != 7 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 6;

                        }

                        if (i == 25 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 4 &&
                            CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 1 && CrashReportRight != 8)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 7;

                        }

                        if (i == 26 && CrashReportRight != 2 && CrashReportRight != 3 && CrashReportRight != 4 &&
                            CrashReportRight != 5 && CrashReportRight != 6 && CrashReportRight != 7 && CrashReportRight != 1)
                        {
                            OtherCar.Life -= 1;
                            CrashReportRight = 8;

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
                                    DrowMyCar(border.FirstRoadLine + 8, i - 2, CarValue);
                                    DrowMyCar(border.FirstRoadLine + 6, i - 2, CarValue);
                                    DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);


                                }
                            
                            if (i == 23)
                            {
                                Clear(border.FirstRoadLine + 8, i - 4);
                                Clear(border.FirstRoadLine + 6, i - 4);
                                DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);                              

                            }

                            if (i == 24)
                            {

                                Clear(border.FirstRoadLine + 7, i - 2);
                                Clear(border.FirstRoadLine + 8, i - 3);
                                Clear(border.FirstRoadLine + 6, i - 3);
                                DrowMyCar(border.FirstRoadLine + 7, i - 3, CarValue);

                            }
                            if (i == 25)
                            {
                                Clear(border.FirstRoadLine + 7, i-3);
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


