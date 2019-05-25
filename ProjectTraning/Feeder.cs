using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Feeder
    {
        public void Feed(Mammal[] mammals)
        {
            foreach (var item in mammals)
            {

                Console.WriteLine($"Mammal {item.name}, mamal age is {item.Age}");
                item.Eat(10);
                Console.WriteLine($"Weght of {item.name} was increased to {item.Weight}");
            }
        }
    }
}
