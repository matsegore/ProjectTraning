using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11_05.Task2
{
    class Plant
    {
        public string name;

        public double color;

        public double height;

        public double Water { get; set; }

        public double Minerals { get; set; }

        public int oxygen;

        public Plant (string name, double color, double height, double water, double minerals, int oxygen)
            
        {
            this.name = name;
            this.color = color;
            this.height = height;
            Water = water;
            Minerals = minerals;
            this.oxygen = oxygen;
        }


        public void Drink()
        {
            Console.WriteLine($"Restoration was poured with {this.Water} liters of water");
        }
        public void Eat()
        {
            Console.WriteLine($"Plant consumed {this.Minerals} minerals");
        }
        public void OxygenRelease()
        {
            Console.WriteLine($"Oxygen {this.oxygen} was released");
        }
    }
}
