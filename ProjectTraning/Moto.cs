using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Moto: Vehicles
    {
        public MotoType Type { get; set; }

        public Moto (MotoType type, int weelCount, ConsoleColor color, int maxSpeed, int passengedrCount)
            :base(weelCount, color, maxSpeed, passengedrCount)
        {
            Type = type;
        }
    }

    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        EndurX
    }
}
