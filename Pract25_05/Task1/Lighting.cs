using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task1
{
    class Lighting : ISwitchable
    {
        public bool status = false;


        public  void Off()
        {
                this.status=false;
        }

        public  void On()
        {
                this.status = true;
        }

        public override string ToString()
        {
            if (this.status == true)
            {
                return "Лампочка включена";
            }
             else
            {
                return "Лампочка выключена";
            }

        }

    }
}
