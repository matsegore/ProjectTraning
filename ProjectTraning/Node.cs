using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class Node<T>
    {
        public T Element { get; set; }

        public Node<T> Next { get; set; }

        public Node(T element)
        {
            this.Element = element;
        }
    }
}

