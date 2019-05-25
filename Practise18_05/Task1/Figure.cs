using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task1
{
    abstract class Figure
    {
         
        public double CenterOfTheFigure { get; set; }

        public Figure(double centerOfTheFigure)
        {
            CenterOfTheFigure = centerOfTheFigure;
        }
        public abstract void Draw();
    }
}

