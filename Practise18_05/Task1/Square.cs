using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task1
{
    class Square : Figure
    {
        public double Side { get; set; }

        public Square(double centerOfTheFigure, double side)
           : base(centerOfTheFigure)
        {
            Side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Square draw using side length {this.Side}");
        }
    }
}
