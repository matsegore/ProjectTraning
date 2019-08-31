using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class FieldOfGame: Draw
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
                CreateElement(i, 0, FieldAndBorderdValue);                
            }

            for (int i = 0; i <= this.width; i++)
            {
                CreateElement(i, this.height, FieldAndBorderdValue);              
            }

            for (int i = 0; i <= this.height; i++)
            {
                CreateElement(0, i, FieldAndBorderdValue);
            }

            for (int i = 0; i <= this.height; i++)
            {
                CreateElement(this.width, i, FieldAndBorderdValue);
            }

            Console.SetWindowSize(91, 29);
        }
    }

}


