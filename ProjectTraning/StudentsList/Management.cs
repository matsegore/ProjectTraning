using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.StudentList
{
    class Management
    {
        public void Execute()
        {
            StudentList studentList = new StudentList();

            var inst = studentList.GetStudentList();

            Console.WriteLine($"Number of elements: {inst.Count}");

            Console.WriteLine($"List has elements:");

            for (int i = 0; i < inst.Count; i++)
            {
                Console.WriteLine(inst[i].ToString());
            }

            Console.WriteLine(Environment.NewLine);

            inst.Add(new Student("ALex", "Pupkin", 5, "GP2019", "GP"));

            Console.WriteLine($"Number of elements: {inst.Count}");

            Console.WriteLine($"List has elements:");

            for (int i = 0; i < inst.Count; i++)
            {
                Console.WriteLine(inst[i].ToString());
            }

            Console.WriteLine(Environment.NewLine);

            inst.RemoveAt(1);

            Console.WriteLine($"Number of elements: {inst.Count}");

            Console.WriteLine($"List has elements:");

            for (int i = 0; i < inst.Count; i++)
            {
                Console.WriteLine(inst[i].ToString());
            }
        }
    }
}