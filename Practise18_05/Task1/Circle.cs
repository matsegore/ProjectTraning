using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task1
{
    class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double centerOfTheFigure, double radius)
            : base(centerOfTheFigure)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"The figure is drawn using a radius - {this.Radius} and center of the figure - {CenterOfTheFigure}");
        }
    }
}
