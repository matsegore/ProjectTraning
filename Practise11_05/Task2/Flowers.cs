using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11_05.Task2
{
    class Flower : Plant
    {
        public string Smell { get; set; }

        public Flower(string name, double color, double height, double water, double minerals, int oxygen, string smell)
            : base (name, color, height, water, minerals, oxygen)
        {
            Smell = smell;
        }

        public void GrowFlowers (double height, double water)
        {
            double growFlowers = (water / 4) + height;
            Console.WriteLine($"{this.name} grew by {growFlowers} units");
        }

        public void EatFlowers(double color, double minerals)
        {
            double eatingFlowers = (minerals / 3) + color;
            Console.WriteLine($"{this.name} color has been changed to {eatingFlowers} units");
        }


    }
}
