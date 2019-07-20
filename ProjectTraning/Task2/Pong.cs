using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning.Task2
{
    class Pong
    {
        public event PingPongDelegate NewPong;

        protected virtual void OnPing(PingPongEventArgs datetime)
        {
            this.NewPong?.Invoke(this, datetime);
        }

        public void PongE()
        {
            var time = DateTime.Now;
            Console.WriteLine($"Pong is done... {Environment.NewLine}");           
            Thread.Sleep(1000);           
            this.OnPing(new PingPongEventArgs(time));           
        }
    }
}
