using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practise18_05.Task1;
using Practise18_05.Task3;
using Practise18_05.Task4;
using Practise18_05.Task2Mamals;
namespace Practise18_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Execute().FigureDrowing();
            //new ExecuteTask3().SayHi();
            //new Calculator().OperationValue();

            Mammal[] mammals = { new Arboreal(1,2, "Arboreal"),
                                 new Aquatic (3,3, "Aquatic")};

            foreach (var item in mammals)
            {
                item.Feed();
            }
        }
    }
}

