using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task_20_07
{
    public class FridgeRefreg
    {
        public event FridgeDelegate Fridge;

        public Enum Status { get; set; } = ModesofOperation.On;

        public Enum MainDor { get; set; } = ModesofOperation.Close;

        public Enum SecondDor { get; set; } = ModesofOperation.Close;

        protected virtual void OnFridge(FridgeEventArgs e)
        {
            this.Fridge?.Invoke(this, e);
        }

        public string StatusOfFridge()
        {
            return $"Status - {Status} \nMainDor - {MainDor} \nSecond Dor - {SecondDor}"; 
        }

        public void FridgeOn()
        {          
            Status = ModesofOperation.On;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nХолодильник принимает статус: ");
            this.OnFridge(new FridgeEventArgs(Status));
            Console.ResetColor();
        }

        public void FridgeOff()
        {
            Status = ModesofOperation.Off;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nХолодильник принимает статус: ");
            this.OnFridge(new FridgeEventArgs(Status));
            Console.ResetColor();
        }

        public void MainDorOpen()
        {
            MainDor = ModesofOperation.Open;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nДверь холодильника принимает статус: ");
            this.OnFridge(new FridgeEventArgs(MainDor));
            Console.ResetColor();
        }

        public void MainDorClose()
        {
            MainDor = ModesofOperation.Close;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nДверь холодильника принимает статус: ");
            this.OnFridge(new FridgeEventArgs(MainDor));
            Console.ResetColor();
        }

        public void SecondDorOpen()
        {
            SecondDor = ModesofOperation.Open;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nДверь морозилки принимает статус: ");
            this.OnFridge(new FridgeEventArgs(SecondDor));
            Console.ResetColor();
        }

        public void SecondDorClose()
        {
            SecondDor = ModesofOperation.Close;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nДверь морозилки принимает статус: ");
            this.OnFridge(new FridgeEventArgs(SecondDor));
            Console.ResetColor();
        }

        public enum ModesofOperation
        {
            On,
            Off,
            Open,
            Close
        }
    }
}
