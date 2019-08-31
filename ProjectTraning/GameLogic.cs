using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ProjectTraning
{
    public class GameLogic : Draw
    {
        public static int MyCarPosition { get; set; }

        Border border = new Border();

        MyCar myCar = new MyCar();

        public void Play()
        {
            myCar.Car();

            GameLogic.MyCarPosition = 3;

            while (true)
            {
                var button = Console.ReadKey(true);

                lock (locker)
                {
                    if (button.Key == ConsoleKey.RightArrow)
                    {
                        GameLogic.MyCarPosition = 2;
                        MoveRight();
                    }

                    else if (button.Key == ConsoleKey.LeftArrow)
                    {
                        MoveLeft();
                        GameLogic.MyCarPosition = 3;
                    }
                }
            }
        }

        public void MoveLeft()
        {
            lock (locker)
            {
                CreateElement(border.FirstRoadLine + 6, 22, CarValue);
                CreateElement(border.FirstRoadLine + 7, 21, CarValue);
                CreateElement(border.FirstRoadLine + 8, 22, CarValue);
                CreateElement(border.FirstRoadLine + 8, 20, CarValue);
                CreateElement(border.FirstRoadLine + 7, 20, CarValue);
                CreateElement(border.FirstRoadLine + 6, 20, CarValue);
                CreateElement(border.FirstRoadLine + 7, 19, CarValue);

                Clear(border.SecondRoadLine - 6, 22);
                Clear(border.SecondRoadLine - 7, 21);
                Clear(border.SecondRoadLine - 8, 22);
                Clear(border.SecondRoadLine - 8, 20);
                Clear(border.SecondRoadLine - 7, 20);
                Clear(border.SecondRoadLine - 6, 20);
                Clear(border.SecondRoadLine - 7, 19);
            }
        }

        public void MoveRight()
        {
            lock (locker)
            {
                CreateElement(border.SecondRoadLine - 6, 22, CarValue);
                CreateElement(border.SecondRoadLine - 7, 21, CarValue);
                CreateElement(border.SecondRoadLine - 8, 22, CarValue);
                CreateElement(border.SecondRoadLine - 8, 20, CarValue);
                CreateElement(border.SecondRoadLine - 7, 20, CarValue);
                CreateElement(border.SecondRoadLine - 6, 20, CarValue);
                CreateElement(border.SecondRoadLine - 7, 19, CarValue);

                Clear(border.FirstRoadLine + 6, 22);
                Clear(border.FirstRoadLine + 7, 21);
                Clear(border.FirstRoadLine + 8, 22);
                Clear(border.FirstRoadLine + 8, 20);
                Clear(border.FirstRoadLine + 7, 20);
                Clear(border.FirstRoadLine + 6, 20);
                Clear(border.FirstRoadLine + 7, 19);
            }
        }

        public void ScoreDisplay()
        {
            lock (locker)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(40, 25);
                Console.Write($"SCORE: ");
            }

            while (true)
            {
                Thread.Sleep(100);

                lock (locker)
                {
                    if (OtherCar.Result == 1)
                    {
                        Console.SetCursorPosition(47, 25);
                        break;
                    }

                    Console.SetCursorPosition(47, 25);
                    Console.Write(OtherCar.Score);
                }
            }
        }

        public void Life()
        {
            lock (locker)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(40, 26);
                Console.Write($"LIFE: ");
            }

            while (true)
            {
                Thread.Sleep(100);

                lock (locker)
                {
                    if (OtherCar.Result == 1)
                    {
                        Console.SetCursorPosition(47, 26);
                        break;
                    }

                    Console.SetCursorPosition(47, 26);
                    Console.Write(OtherCar.Life);
                }
            }
        }

        public int Speed()
        {
            int temp = 1;

            if (OtherCar.Score >=50 && OtherCar.Score < 100)
            {
                temp = 2;
            }
            else if (OtherCar.Score >= 100)
            {
                temp = 4;
            }

                return temp;
        }

    }
}



