using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practise11_05.Task1;
using Practise11_05.Task2;

namespace Practise11_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Figure[] figures = 
            {
            new Triangle(123, 12, 34, 12),
            new Square(123.23, 12, 32),
            new Circle(125.23, 43),
            new Rhombus(123.2, 45)
            };
            foreach (var item in figures)
            {
                if (item is Triangle triangle)
                {
                    triangle.Draw();
                }

                if (item is Square square)
                {
                    square.Draw();
                }

                if (item is Circle circle)
                {
                    circle.Draw();
                }
            }*/
            Worker worker1 = new Worker("Fedor", "Petrov");
            Worker worker2 = new Worker("Alex", "Sydorov");

            Gallery gallery = new Gallery("on", "on");
            if (gallery.waterAndMineralsSystem == "on")
            {

                Plant[] plants =
                {
                new Flower ("Othideya", 12, 1, 2, 3, 9, "fresh smell"),
                new Tree ("Dub", 12, 1, 2, 3, 8, "good bark"),
                new Tree ("Spruce", 12, 1, 2, 3, 12, "black bark"),
            };
            
                foreach (var item in plants)
                {
                    if (item is Flower flowers)
                    {
                        Console.WriteLine($"{flowers.name} color is {flowers.color}, height {flowers.height} and have {flowers.Smell}");
                        Console.WriteLine($"{flowers.name} were watered by {flowers.Water} liters of water and feed {flowers.Minerals} of minerals by {worker1.nameOfWorker} {worker1.secondNameOfWorker}");
                        flowers.GrowFlowers(1, 2);
                        flowers.EatFlowers(12, 3);
                        if (gallery.lighting == "on")
                        {
                            Console.WriteLine($"{flowers.name} emit oxygen in size {flowers.oxygen}");
                        }
                        else
                        {
                            Console.WriteLine("Flowers do not give off oxygen, turn on the light");
                        }
                    }
                    if (item is Tree trees)
                    {
                        Console.WriteLine($"{trees.name} color is {trees.color}, height {trees.height} and have {trees.Bark}");
                        Console.WriteLine($"{trees.name} were watered by {trees.Water} liters of waterand and feed {trees.Minerals} of minerals by {worker2.nameOfWorker} {worker2.secondNameOfWorker}");
                        trees.GrowTrees(1, 2);
                        trees.EatTrees(12, 3);
                        if (gallery.lighting == "on")
                        {
                            Console.WriteLine($"{trees.name} emit oxygen in size {trees.oxygen}");
                        }
                        else
                        {
                            Console.WriteLine("Trees do not give off oxygen, turn on the light");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Turn on water supply system to display information about watering and feeding ");
            }

            
        }
    }
}
