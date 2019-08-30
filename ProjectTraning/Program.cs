using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            random.Next(3, 19);

            new FieldOfGame().BordersOfField();

            

            Thread thr = new Thread(new ThreadStart(new Border().NewBorder));
            thr.Start();

            Thread thr3 = new Thread(new ThreadStart(new GameLogic().Play));
            thr3.Start();

            Thread thr4 = new Thread(new ThreadStart(new GameLogic().ScoreCalculate));
            thr4.Start();

            Thread thr5 = new Thread(new ThreadStart(new GameLogic().Life));
            thr5.Start();

            for (int i = 0; i <= 16; i++)
            {
                Thread.Sleep(200);


                if (i == random.Next(1, 2))
                {

                    Thread thr1 = new Thread(new ThreadStart(new OtherCar().CarFallingLeft));
                    thr1.Start();

                }

                if (i == random.Next(6, 7))
                {

                    Thread thr2 = new Thread(new ThreadStart(new OtherCar().CarFallingRight));
                    thr2.Start();
                }
            }

            //for (int i = 0; i <= 2; i++)
            //{

            //  int temp = random.Next(1,2);

            //    if (temp == 1)
            //    {
            //        Thread thr1 = new Thread(new ThreadStart(new OtherCar().CarFallingLeft));
            //        thr1.Start();
            //    }
            //}
        }
    }
}
