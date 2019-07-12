using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task3
{
    class American : Human
    {
            public American(string name)
            : base(name) { }

            public override void SayHello()
            {
                Console.WriteLine($"{GetType().Name} Hi");
            }
    }
}

