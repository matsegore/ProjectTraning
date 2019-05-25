using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Bicycle: Vehicles
    {
        public BicycleType Type { get; set; }
        public BreakType Brake { get; set; }


        public Bicycle(BicycleType type, BreakType brake, int weelCount, ConsoleColor color, int maxSpeed, int passengedrCount)
            : base(weelCount, color, maxSpeed, passengedrCount)
        {
            Type = type;
            Brake = brake;
        }
    }

    enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX
    }
    enum BreakType
    {
        andBrakes,
        FootBrakes
    }
}
