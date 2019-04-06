using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колво секунд");
            int sec = Convert.ToInt32(Console.ReadLine());
            int hour = sec / 3600;
            Console.WriteLine($"Прошло полных часов {hour}");
            if (hour == 24)
            {
                Console.WriteLine("Прошел 1 день");
            }
            else if (hour > 24)
            {
                Console.WriteLine("Вы вышли за диапазон 1го дня");
            }
        }
    }
}
