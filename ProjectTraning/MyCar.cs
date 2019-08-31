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
                DrawMyCar(border.FirstRoadLine + 6, 22, CarValue);
                DrawMyCar(border.FirstRoadLine + 7, 21, CarValue);
                DrawMyCar(border.FirstRoadLine + 8, 22, CarValue);
                DrawMyCar(border.FirstRoadLine + 8, 20, CarValue);
                DrawMyCar(border.FirstRoadLine + 7, 20, CarValue);
                DrawMyCar(border.FirstRoadLine + 6, 20, CarValue);
                DrawMyCar(border.FirstRoadLine + 7, 19, CarValue);
            }
                       
        }

    }
}
