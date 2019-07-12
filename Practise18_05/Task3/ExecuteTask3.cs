using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise18_05.Task3
{
    class ExecuteTask3
    {
        public void SayHi()
        {
            Human[] human =
            {
                new American ("Jhonn"),
                new Ukrainian ("Василь")
            };
            foreach (var item in human)
            {
              item.SayHello();
            }
        }
    }
}
