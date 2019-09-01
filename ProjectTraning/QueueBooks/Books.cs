using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.QueueBooks
{
    class Books
    {

        private string name;

        private string writer;

        public int Number { get; }

        public Books(int number, string name, string writer)
        {
            this.Number = number;

            this.name = name;

            this.writer = writer;
        }

        public override string ToString()
        {
            return this.Number + " - " + this.name + ", " + this.writer;
        }
    }
}
