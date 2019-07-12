using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task2Mamals
{
    class Arial : Mammal
    {
        public Arial(int age, int weight, string name)
             : base(age, weight, name)
        {

        }

        public override void Feed()
        {
            Console.WriteLine($"Mammal {this.name}, mamal age is {this.Age}");
            this.Eat(10);
            Console.WriteLine($"Weght of {this.name} was increased to {this.Weight}");
        }
    }
}
