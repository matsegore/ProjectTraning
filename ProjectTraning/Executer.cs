using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class Executer
    {
        Random random = new Random();

        public void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            new FieldOfGame().BordersOfField();

            Thread bordersOfRoad = new Thread(new ThreadStart(new Border().NewBorder));
            Console.ForegroundColor = ConsoleColor.Blue;
            bordersOfRoad.Start();


            Thread play = new Thread(new ThreadStart(new GameLogic().Play));

            play.Start();

            Thread Score = new Thread(new ThreadStart(new GameLogic().ScoreDisplay));
            Score.Start();

            Thread Life = new Thread(new ThreadStart(new GameLogic().Life));
            Life.Start();

            for (int i = 0; i <= 13; i++)
            {
                Thread.Sleep(200 / new GameLogic().Speed());

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
        }
    }
}
