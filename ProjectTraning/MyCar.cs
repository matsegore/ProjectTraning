using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class MyCar: Draw
    {
        Border border = new Border();

        public void Car()
        {
            lock (locker)
            {
                DrowMyCar(border.FirstRoadLine + 6, 22, "x");
                DrowMyCar(border.FirstRoadLine + 7, 21, "x");
                DrowMyCar(border.FirstRoadLine + 8, 22, "x");
                DrowMyCar(border.FirstRoadLine + 8, 20, "x");
                DrowMyCar(border.FirstRoadLine + 7, 20, "x");
                DrowMyCar(border.FirstRoadLine + 6, 20, "x");
                DrowMyCar(border.FirstRoadLine + 7, 19, "x");
            }
                       
        }

    }
}
