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

        protected virtual void OnFridge(FridgeEventArgs e)
        {
            this.Fridge?.Invoke(this, e);
        }

        public void FridgeOn()
        {
            ModesofOperation On;
            On = ModesofOperation.On;
            this.OnFridge(new FridgeEventArgs());
        }

        public void FridgeOff()
        {
            ModesofOperation Off;
            Off = ModesofOperation.Off;
            this.OnFridge(new FridgeEventArgs());
        }

        public void MainDorOpen()
        {
            ModesofOperation OpenMainDor;
            OpenMainDor = ModesofOperation.OpenMainDor;
            this.OnFridge(new FridgeEventArgs());
        }

        public void MainDorClose()
        {
            ModesofOperation ClosMaineDor;
            ClosMaineDor = ModesofOperation.ClosMaineDor;
            this.OnFridge(new FridgeEventArgs());
        }

        public void SecondDorOpen()
        {
            ModesofOperation OpenSecondDor;
            OpenSecondDor = ModesofOperation.OpenSecondDor;
            this.OnFridge(new FridgeEventArgs());
        }

        public void SecondDorClose()
        {

            ModesofOperation ClosSecondDor;
            ClosSecondDor = ModesofOperation.ClosSecondDor;
            this.OnFridge(new FridgeEventArgs());
        }

        public enum ModesofOperation
        {
            On,
            Off,
            OpenMainDor,
            ClosMaineDor,
            OpenSecondDor,
            ClosSecondDor
        }
    }
}
