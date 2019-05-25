using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Car : Vehicles
    {
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearBoxType GearBox { get; set; }


        public Car(int doorsCount, EngineType engine, GearBoxType gearBox, int weelCount, ConsoleColor color, int maxSpeed, int passengedrCount)
            : base(weelCount, color, maxSpeed, passengedrCount)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            GearBox = gearBox;
        }
    }

    enum EngineType
    {
        Petrol,
        Diesel,
        Electro,
    }
    enum GearBoxType
    {
        Manual,
        Auto,
        robot

    }
}
