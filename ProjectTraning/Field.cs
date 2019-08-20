using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Field
    {
        public int Height;

        public int Width;

        public Field()
        {
            this.Height = 20;

            this.Width = 10;

            Console.SetWindowSize(40, 50);
        }
    }
}
