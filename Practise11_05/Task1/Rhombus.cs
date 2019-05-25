using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11_05.Task1
{
    class Rhombus : Figure
    {
        public double Side { get; set; }

        public Rhombus(double centerOfTheFigure, double side)
           : base(centerOfTheFigure)
        {
            Side = side;
        }
    }
}
