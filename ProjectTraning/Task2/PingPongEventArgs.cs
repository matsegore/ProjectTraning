using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task2
{
    public class PingPongEventArgs: EventArgs
    {
        private DateTime eventTime;

        public PingPongEventArgs (DateTime eventTime)
        {
            this.eventTime = eventTime;
        }

        public override string ToString()
        {
            return eventTime.ToString();
        }
    }
}
