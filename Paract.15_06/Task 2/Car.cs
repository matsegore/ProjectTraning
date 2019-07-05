using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paract._15_06.Task_2
{
    class Car : ICar
    {
       public int Year { get; set; }

        public string Name { get; set; }



        public Car(int year, string name)
        {
            this.Year = year;
            this.Name = name;
        }

        public override string ToString()
        {

            return $" {this.Year}  {this.Name} \n";
        }
    }
}
