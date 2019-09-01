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


            for (int i = 0; i < 50; i++)
            {
               Thread.Sleep(500);
                    Thread thr = new Thread(new ThreadStart(new Matrix().NewMatrics));
                    thr.Start();
            }
        }
    }
}
