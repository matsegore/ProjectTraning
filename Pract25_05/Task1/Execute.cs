using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task1
{
    class Execute
    {
        Lighting lighting = new Lighting();

        
        public void TernOnOrOffLighting()
        {
            Console.WriteLine(lighting.ToString());
            while (true)
            {
                if (lighting.status == true)
                {
                    Console.WriteLine("Выключите свет нажав 1");
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        lighting.Off();
                        Console.WriteLine(lighting.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Вы оставили свет включенным");
                        break;
                    }
                }
                if (lighting.status == false)
                {
                    Console.WriteLine("Включите свет нажав 2");
                    int result2 = Convert.ToInt32(Console.ReadLine());
                    if (result2 == 2)
                    {
                        lighting.On();
                        Console.WriteLine(lighting.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Вы оставили свет выключенным");
                        break;
                    }
                }
            }
        }
        }

    }

