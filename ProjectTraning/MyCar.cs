using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class MyCar: Draw
    {
        Border border = new Border();

        public void Car()
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
            }                     
        }
    }
}
