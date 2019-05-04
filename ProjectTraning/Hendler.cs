using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class Hendler
    {
        public void Execute()
        {
            My_Class myClassInstance = new My_Class();
            myClassInstance.SetClassField("Initialide class field value");

            My_Struct myStrInst = new My_Struct();
            myStrInst.SetStructureField("Initialide Struct field value");

            this.Change(myClassInstance);
            this.Change(myStrInst);

            Console.WriteLine($"Class Field is: {myClassInstance.GetClassFeeld()}");
            Console.WriteLine($"Struct Field is: {myStrInst.GetStrFeeld()}");
        }


        private void Change( My_Class instance)
        {
            instance.SetClassField("Class has been changed");
        }

        private void Change(My_Struct instance)
        {
            instance.SetStructureField("Structure has been changed");
        }
    }
}
