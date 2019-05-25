using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11_05.Task1
{
    class Square : Figure
    {
        public double FirstSide  { get; set; }

        public double SecondSide { get; set; }

        public Square (double centerOfTheFigure, double firstside, double secondside)
            : base(centerOfTheFigure)
        {
            FirstSide = firstside;
            SecondSide = secondside;
        }

        public void Draw()
        {
            Console.WriteLine($"The figure is drawn using first side - {this.FirstSide}  second side {this.SecondSide} and center of the figure - {CenterOfTheFigure}");
        }
    }
}
