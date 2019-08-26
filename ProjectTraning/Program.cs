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
            Thread thrTwo = new Thread(new ThreadStart(new Field().BordersOfField));
            thrTwo.Start();

            Thread thr = new Thread(new ThreadStart(new Border().NewMatrics));
            thr.Start();

            
        }
    }
}
