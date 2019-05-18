using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise11_05.Task2
{
    class Tree : Plant
    {
        public string Bark { get; set; }

        public Tree(string name, double color, double height, double water, double minerals, int oxygen, string bark)
            : base(name, color, height, water, minerals, oxygen)
        {
            Bark = bark;
        }

        public void GrowTrees(double height, double water)
        {
            double growTrees = (water / 8) + height;
            Console.WriteLine($"{this.name} grew by {growTrees} units");
        }

        public void EatTrees(double color, double minerals)
        {
            double eatingTrees = (minerals / 6) + color;
            Console.WriteLine($"{this.name} color has been changed to {eatingTrees} units");
        }
    }
}
