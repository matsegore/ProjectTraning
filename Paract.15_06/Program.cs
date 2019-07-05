using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paract._15_06.Task1;
using Paract._15_06.Task_2;
namespace Paract._15_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //var date1 = DateTime.Today;
            //Console.WriteLine(date1.ToString("MM.dd.yyy"));

            //var yesterday = date1.AddDays(-1);
            //Console.WriteLine(yesterday);

            //var subMonth = date1.AddMonths(-2);
            //Console.WriteLine(subMonth);

            //var subYear = date1.AddYears(-1);
            //Console.WriteLine(subYear);

            //var birthDate = new DateTime(1994, 5, 16);
            //Console.WriteLine(birthDate);

            //MaList<int> array = new MaList<int>();
            //array.Add(2);
            //array.Add(3);
            //array.Add(4);
            //Console.WriteLine($"Info about array {array.ToString()}");

            CarColection<Car> array = new CarColection<Car>();

            array.Add(new Car(1994, "Ford"));
            array.Add(new Car(1995, "Fiat"));
            Console.WriteLine(array.ToString());

            Console.Write("Number of cars:");
            array.Contains();

            array.Clear();
            Console.WriteLine($"Clear array: {array}");
            

        }
    }
}
