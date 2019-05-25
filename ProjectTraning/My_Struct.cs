using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    struct My_Struct
    {
        private string change;
        
        public string GetStrFeeld()
        {
            return this.change;
        }
        public void SetStructureField (string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}
