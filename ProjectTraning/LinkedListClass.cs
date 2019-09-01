﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class LinkedListClass<T>
    {
        private Node<T> firstElement;

        private Node<T> lastElement;

        private int count;

        public void Add(T element)
        {
            Node<T> node = new Node<T>(element);

            if (this.firstElement == null)

            {
                this.firstElement = node;
            }

            else
            {
                this.lastElement.Next = node;
            }

            this.lastElement = node;

            this.count++;
        }

        public void Display(Node<T> node = null)
        {
            var currentNode = node ?? this.firstElement;

            Console.WriteLine(currentNode.Element.ToString());

            if (currentNode.Next is null)

                return;

            this.Display(currentNode.Next);
        }

        public void Display2()
        {
            var currentNode = this.firstElement;

            Console.WriteLine(currentNode.Element);

            for (int i = 0; i < count - 1; i++)
            {
                currentNode = currentNode.Next;

                Console.WriteLine(currentNode.Element);
            }
        }
    }
}
