using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task_20_07
{
    public class FridgeEventArgs : EventArgs
    {
        public Enum Status { get; set; }

        public FridgeEventArgs(Enum status)
        {
            this.Status = status;
        }
    }
}
