using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task_20_07
{
    public class User
    {
        public event FridgeDelegate NewAction;

        protected virtual void OnAction(FridgeEventArgs e)
        {
            this.NewAction?.Invoke(this, e);
        }

        public void Off()
        {
            Console.WriteLine("Хоолодильник выключен");
            this.OnAction(new FridgeEventArgs());
        }

        public void On()
        {
            Console.WriteLine("Хоолодильник включен");
            this.OnAction(new FridgeEventArgs());
        }

        public void MainDorOpen()
        {
            Console.WriteLine("Главная дверь открыта");
            this.OnAction(new FridgeEventArgs());
        }

        public void MainDorClose()
        {
            Console.WriteLine("Главная дверь закрыта");
            this.OnAction(new FridgeEventArgs());
        }

        public void SecondDorOpen()
        {
            Console.WriteLine("Морозилка открыта");
            this.OnAction(new FridgeEventArgs());
        }

        public void SecondDorClose()
        {
            Console.WriteLine("Морозилка закрыта");
            this.OnAction(new FridgeEventArgs());
        }
    }
}
