using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task1
{
    class Execute
    {
        public void FigureDrowing()
        {
            Figure[] figure =
                   {
                new Circle (2,3),
                new Triangle (3,6,8,7),
                new Square (8,9)
                };
            foreach (var item in figure)
            {
                item.Draw();
            }
        }
    }
}

