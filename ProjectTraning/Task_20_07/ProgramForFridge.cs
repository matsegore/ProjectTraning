using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task_20_07
{
    public delegate void FridgeDelegate(object a, FridgeEventArgs e);

    public class ProgramForFridge
    {
        public FridgeRefreg Fridge { get; set; }

        public ProgramForFridge()
        {
            this.Fridge = new FridgeRefreg();

            this.Fridge.Fridge += EventInvoke;

        }


        public void Execute()

        {
            while (true)
            {

                Console.WriteLine($"Состояние холодильника: \n{Fridge.StatusOfFridge()}");

                Console.WriteLine("\nВыберите действие \n 1 - включить холодильник \n 2 - выключить холодильник \n 3 - открыть основную дверь \n 4 - закрыть основную дверь \n 5 - открыть морозилку \n 6 - закрыть морозилку \n 7 - выход из программы управления");
                int result = Convert.ToInt32(Console.ReadLine());

                if(result == 1)
                {
                    Fridge.FridgeOn();
                }

                if (result == 2)
                {
                    Fridge.FridgeOff();
                }

                if (result == 3)
                {
                    Fridge.MainDorOpen();
                }

                if (result == 4)
                {
                    Fridge.MainDorClose();
                }

                if (result == 5)
                {
                    Fridge.SecondDorOpen();
                }

                if (result == 6)
                {
                    Fridge.SecondDorClose();
                }

                if (result == 7)
                {
                    break;
                }

            }
        }

        public void EventInvoke(object a, FridgeEventArgs e)
        {
            Console.WriteLine(e.Status);
        }
    }
}
