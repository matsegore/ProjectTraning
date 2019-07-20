using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning.Task1
{
    class Pong
    {
        public event EventHandler NewPong;

        protected virtual void OnPing(EventArgs e)
        {
            this.NewPong?.Invoke(this, e);
        }

        public void PongE()
        {
            Console.WriteLine($"Pong is done... {Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing(new EventArgs());
        }
    }
}
