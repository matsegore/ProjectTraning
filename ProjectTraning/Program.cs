﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTraning.StudentList;
using ProjectTraning.StudentsDictionary;
using ProjectTraning.TasksStak;
using ProjectTraning.QueueBooks;

namespace ProjectTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Management().Execute();
            //new Dictionary().DictionaryExecute();
            //new QueueManagement().QueueExecute();
            new BookManagment().StackExecute();
        }
    }
}
