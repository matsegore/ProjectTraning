using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class OtherCar : Draw
    {
        Border border = new Border();

        public void CarFolen()
        {

            while (true)
            {

                for (int i = 3, y = 3; i < 23+4; i++)
                {

                    Thread.Sleep(100);
                    lock (locker)
                    {
                        if (i == 3)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, 3, "+");
                        }

                        if (i == 4)
                        {
                            DrowMyCar(border.SecondRoadLine - 6, 3, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 3, "+");
                            DrowMyCar(border.SecondRoadLine - 8, 3, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 4, "+");                            
                        }

                        if (i == 5)
                        {
                            Clear(border.SecondRoadLine - 6, 3);
                            DrowMyCar(border.SecondRoadLine - 7, 3, "+");
                            Clear(border.SecondRoadLine - 8, 3);
                            DrowMyCar(border.SecondRoadLine - 6, 4, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 4, "+");
                            DrowMyCar(border.SecondRoadLine - 8, 4, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 5, "+");
                        }

                        if (i == 6)
                        {
                            DrowMyCar(border.SecondRoadLine - 8, 3, "+");
                            Clear(border.SecondRoadLine - 7, 3);
                            DrowMyCar(border.SecondRoadLine - 6, 3, "+");
                            Clear(border.SecondRoadLine - 6, 4);
                            DrowMyCar(border.SecondRoadLine - 7, 4, "+");
                            Clear(border.SecondRoadLine - 8, 4);
                            DrowMyCar(border.SecondRoadLine - 6, 5, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 5, "+");
                            DrowMyCar(border.SecondRoadLine - 8, 5, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 6, "+");
                        }


                        if (i>6 && i < 23)
                        {
                            DrowMyCar(border.SecondRoadLine - 7, i, "+");
                            DrowMyCar(border.SecondRoadLine - 6, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 1, "+");
                            DrowMyCar(border.SecondRoadLine - 6, i - 2, " ");
                            DrowMyCar(border.SecondRoadLine - 7, i - 2, "+");
                            DrowMyCar(border.SecondRoadLine - 8, i - 2, " ");
                            DrowMyCar(border.SecondRoadLine - 6, i - 3, "+");
                            DrowMyCar(border.SecondRoadLine - 7, i - 3, " ");
                            DrowMyCar(border.SecondRoadLine - 8, i - 3, "+");
                            Clear(border.SecondRoadLine - 6, i - 4);
                            Clear(border.SecondRoadLine - 8, i - 4);
                        }

                        //if (i < 8)
                        //{
                        //    for (int j = 1; j < 4; j++)
                        //    {
                        //        DrowMyCar(border.SecondRoadLine - 7, j, " ");
                        //        DrowMyCar(border.SecondRoadLine - 6, j, " ");
                        //        DrowMyCar(border.SecondRoadLine - 8, j, " ");

                        //    }
                        //}

                        //if (i >= y && i < 23)
                        //{
                        //    DrowMyCar(border.SecondRoadLine - 7, y, " ");
                        //    DrowMyCar(border.SecondRoadLine - 6, y, " ");
                        //    DrowMyCar(border.SecondRoadLine - 8, y, " ");
                        //    y++;
                        //}

                        if (i == 23)
                        {
                            
                            DrowMyCar(border.SecondRoadLine - 6, 22, "+");
                            DrowMyCar(border.SecondRoadLine - 7, 22, "+");
                            DrowMyCar(border.SecondRoadLine - 8, 22, "+");
                            Clear(border.SecondRoadLine - 6, 21);
                            DrowMyCar(border.SecondRoadLine - 7, 21, "+");
                            Clear(border.SecondRoadLine - 8, 21);
                            DrowMyCar(border.SecondRoadLine - 6, 20, "+");
                            Clear(border.SecondRoadLine - 7, 20);
                            DrowMyCar(border.SecondRoadLine - 8, 20, "+");
                            Clear(border.SecondRoadLine - 6, 19);
                            Clear(border.SecondRoadLine - 8, 19);
                        }

                        if (i == 24)
                        {
                            Clear(border.SecondRoadLine - 6, 22);
                            DrowMyCar(border.SecondRoadLine - 7, 22, "+");
                            Clear(border.SecondRoadLine - 8, 22);                         
                            DrowMyCar(border.SecondRoadLine - 6, 21, "+");
                            Clear(border.SecondRoadLine - 7, 21);
                            DrowMyCar(border.SecondRoadLine - 8, 21, "+");
                            Clear(border.SecondRoadLine - 6, 20);
                            Clear(border.SecondRoadLine - 8, 20);
                        }

                        if (i == 25)
                        {                           
                            DrowMyCar(border.SecondRoadLine - 6, 22, "+");
                            Clear(border.SecondRoadLine - 7, 22);
                            DrowMyCar(border.SecondRoadLine - 8, 22, "+");
                            Clear(border.SecondRoadLine - 6, 21);
                            Clear(border.SecondRoadLine - 8, 21);
                        }

                        if (i == 26)
                        {                           
                            Clear(border.SecondRoadLine - 6, 22);
                            Clear(border.SecondRoadLine - 8, 22);
                        }

                        //if (i >= 23)
                        //{

                        //    DrowMyCar(border.SecondRoadLine - 7, 23, " ");
                        //    DrowMyCar(border.SecondRoadLine - 6, 22, " ");
                        //    DrowMyCar(border.SecondRoadLine - 7, 22, " ");
                        //    DrowMyCar(border.SecondRoadLine - 8, 22, " ");
                        //    DrowMyCar(border.SecondRoadLine - 6, 21, " ");
                        //    DrowMyCar(border.SecondRoadLine - 7, 21, " ");
                        //    DrowMyCar(border.SecondRoadLine - 8, 21, " ");

                        //}
                    }


                }
            }
        }
    }
}
