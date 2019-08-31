using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class Border: Draw
    {
        int roadHeight;

        public int FirstRoadLine { get; set; }

        public int SecondRoadLine { get; set; }

        public Border()
        {
            this.roadHeight = 20;

            this.FirstRoadLine = 30;

            this.SecondRoadLine = 60;
        }

        public void NewBorder()
        {
            while (true)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Thread.Sleep(200);

                    lock (Draw.locker)
                    {
                        for (int i = 0; i < this.roadHeight + 1; i++)
                        {
                            Console.CursorVisible = false;
                            
                            if (i % 4 != 0)
                            {
                                CreateElement(this.FirstRoadLine, i + j, FieldAndBorderdValue);
                                CreateElement(this.SecondRoadLine, i + j, FieldAndBorderdValue);
                                
                            }

                            else if (i % 4 == 0)
                            {
                                CreateElement(this.FirstRoadLine, i + j, " ");
                                CreateElement(this.SecondRoadLine, i + j, " ");
                            }
                        }
                    }
                }
            }
        }
    }
}



