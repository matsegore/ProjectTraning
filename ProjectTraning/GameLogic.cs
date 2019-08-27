using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class GameLogic : Draw
    {
        MyCar mycar = new MyCar();

        Border border = new Border();

        OtherCar othercar = new OtherCar();
        public void Play()
        {

            mycar.Car();
            othercar.CarFolen();
            while (true)
            {
                var button = Console.ReadKey(true);

                lock (locker)
                {
                    if (button.Key == ConsoleKey.RightArrow)
                    {
                        MuveRight();
                    }

                    else if (button.Key == ConsoleKey.LeftArrow)
                    {
                        MuveLeft();
                    }

                    
                }
            }


        }

        public void MuveLeft()
        {
            DrowMyCar(border.FirstRoadLine + 6, 22, "x");
            DrowMyCar(border.FirstRoadLine + 7, 21, "x");
            DrowMyCar(border.FirstRoadLine + 8, 22, "x");
            DrowMyCar(border.FirstRoadLine + 8, 20, "x");
            DrowMyCar(border.FirstRoadLine + 7, 20, "x");
            DrowMyCar(border.FirstRoadLine + 6, 20, "x");
            DrowMyCar(border.FirstRoadLine + 7, 19, "x");

            Clear(border.SecondRoadLine - 6, 22);
            Clear(border.SecondRoadLine - 7, 21);
            Clear(border.SecondRoadLine - 8, 22);
            Clear(border.SecondRoadLine - 8, 20);
            Clear(border.SecondRoadLine - 7, 20);
            Clear(border.SecondRoadLine - 6, 20);
            Clear(border.SecondRoadLine - 7, 19);
        }

        public void MuveRight()
        {
            DrowMyCar(border.SecondRoadLine - 6, 22, "x");
            DrowMyCar(border.SecondRoadLine - 7, 21, "x");
            DrowMyCar(border.SecondRoadLine - 8, 22, "x");
            DrowMyCar(border.SecondRoadLine - 8, 20, "x");
            DrowMyCar(border.SecondRoadLine - 7, 20, "x");
            DrowMyCar(border.SecondRoadLine - 6, 20, "x");
            DrowMyCar(border.SecondRoadLine - 7, 19, "x");

            Clear(border.FirstRoadLine + 6, 22);
            Clear(border.FirstRoadLine + 7, 21);
            Clear(border.FirstRoadLine + 8, 22);
            Clear(border.FirstRoadLine + 8, 20);
            Clear(border.FirstRoadLine + 7, 20);
            Clear(border.FirstRoadLine + 6, 20);
            Clear(border.FirstRoadLine + 7, 19);
        }



        public void Clear(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" ");
        }
    }
}
