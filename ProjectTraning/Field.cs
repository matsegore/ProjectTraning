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
            this.Height = 28;

            this.Width = 90;
        }

        public void BordersOfField()
        {
            for (int i = 0; i <= this.Width; i++)
            {
                Console.Write("*");
                for (int j = 0; j <= this.Height; j++)
                {
                    if (i == this.Width)
                    {
                        Console.WriteLine("0");
                    }
                }

            }

            //for (int i = 0; i <= this.Width; i++)
            //{
            //    Console.WriteLine("*");

            //    if (i == this.Height)
            //    {
            //        for (int j = 0; j < this.Width; j++)
            //        {
            //            Console.Write("!");
            //        }

            //    }

            //}

        }


    }
}

