using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class ControlList
    {

        private LinkedListClass<int> singleLinkedList = new LinkedListClass<int>();

        public void Execute()
        {

            singleLinkedList.Add(10);

            singleLinkedList.Add(22);

            singleLinkedList.Add(44);

            singleLinkedList.Display();

            singleLinkedList.Display2();
        }

    }
}

