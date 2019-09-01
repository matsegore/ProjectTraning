using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class HuntEventArgs : EventArgs
    {
            public int FirstCoordinate;

            public int SecondCoordinate;

            public HuntEventArgs(int firstCoordinate, int secondCoordinate)

            {
                this.FirstCoordinate = firstCoordinate;

                this.SecondCoordinate = secondCoordinate;
            }

        }
    }

