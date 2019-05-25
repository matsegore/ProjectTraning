using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Program
    {
        static void Main (string[] agrs)
        {
            Mammal[] mammals = { new Arboreal(1,2, "Arboreal"),
                                 new Aquatic (3,3, "Aquatic")};
       
            new Feeder().Feed(mammals);
        }
        
    }
}
