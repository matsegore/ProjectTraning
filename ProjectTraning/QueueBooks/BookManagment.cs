﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.QueueBooks
{
    class BookManagment
    {
        public void StackExecute()
        {
            BookList instance = new BookList();

            var listOfBooks = instance.GetBookList();

            Stack<Books> stackOfBooks = new Stack<Books>();

            Console.WriteLine("List of books:");

            for (int i = 0; i < listOfBooks.Count; i++)
            {
                stackOfBooks.Push(listOfBooks.ElementAt(i));

                Console.WriteLine($"Book {stackOfBooks.Peek()} was taken.");
            }

            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < stackOfBooks.Count;)
            {
                Console.WriteLine($"Book {stackOfBooks.Peek()} was returned.");

                stackOfBooks.Pop();
            }
        }
    }
}
