using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning.Task2
{
    class Ping
    {
        public event PingPongDelegate NewPing;

        protected virtual void OnPing(PingPongEventArgs datetime)
        {
            this.NewPing?.Invoke(this, datetime);
        }


        public void PingE()
        {
            var time =  DateTime.Now;
            Console.WriteLine($"Ping is done... {Environment.NewLine}");          
            Thread.Sleep(1000);
            this.OnPing(new PingPongEventArgs(time));
        }
    }
}
