using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class OtherCar: Draw
    {
        Border border = new Border();

        public void CarFolen()
        {
            for (int i = 2, y; i < 28; i++)
            {
                Thread.Sleep(300);

                DrowMyCar(border.SecondRoadLine - 7, i, "+");
                DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                DrowMyCar(border.SecondRoadLine - 6, i - 8, "+");
            }
        }
    }
}
