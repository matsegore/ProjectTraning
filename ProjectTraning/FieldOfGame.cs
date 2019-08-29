using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class FieldOfGame
    {
        private int height;

        private int width;

        public FieldOfGame()
        {
            this.height = 28;

            this.width = 90;
        }

        public void BordersOfField()
        {
            
            for (int i = 0; i <= this.width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("O");
            }

            for (int i = 0; i <= this.width; i++)
            {
                Console.SetCursorPosition(i, this.height);
                Console.Write("O");
            }

            for (int i = 0; i <= this.height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("O");
            }

            for (int i = 0; i <= this.height; i++)
            {
                Console.SetCursorPosition(this.width, i);
                Console.WriteLine("O");
            }
            Console.SetWindowSize(91, 29);
        }
    }

}


