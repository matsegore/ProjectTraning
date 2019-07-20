using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning.Task1
{
    class Ping
    {
        public event EventHandler NewPing;

        protected virtual void OnPing (EventArgs e)
        {
            this.NewPing?.Invoke(this, e);
        }


        public void PingE()
        {
            Console.WriteLine($"Ping is done... {Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing(new EventArgs());
        }
    }
}
