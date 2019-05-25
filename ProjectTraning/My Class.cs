using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class My_Class
    {
        private string change;

        public string GetClassFeeld()
        {
            return this.change;
        }
        public void SetClassField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}
