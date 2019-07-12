using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task3
{
    class Ukrainian : Human
    {


        public Ukrainian(string name)
        : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} Привiт");
        }
    }
}
