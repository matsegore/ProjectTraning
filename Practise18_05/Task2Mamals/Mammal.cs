using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task2Mamals
{
    abstract class  Mammal
    {
        public int Age { get; set; }

        public int Weight { get; set; }

        public string name;

        public Mammal(int age, int weight, string name)
        {
            Age = age;
            Weight = weight;
            this.name = name;
        }

        public void Eat(int foodAmount)
        {
            if (foodAmount > 0 && foodAmount % 5 == 0)
            {
                this.Weight += (foodAmount / 5);
            }

            if (this.Age <= 1)
            {
                Console.WriteLine("Mamal eat milck");
            }

            else if (this.Age > 1)
            {
                Console.WriteLine("Mamal eat food");
            }
        }

        public abstract void Feed();
    }
}
