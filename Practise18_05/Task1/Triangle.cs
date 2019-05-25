using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task1
{
    class Triangle : Figure
    {
        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }

        public Triangle(double centerOfTheFigure, double firstside, double secondside, double thirdSide)
            : base(centerOfTheFigure)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            ThirdSide = thirdSide;
        }

        public override void Draw()
        {
            Console.WriteLine($"The figure is drawn using first side - {this.FirstSide}  second side {this.SecondSide} third side {this.ThirdSide} and center of the figure - {CenterOfTheFigure}");

        }
    }
}
