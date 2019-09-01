using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTraning.StudentList;

namespace ProjectTraning.StudentsDictionary
{
    class Dictionary
    {
        public void DictionaryExecute()
        {
            StudentDictionary instance = new StudentDictionary();

            var studentDict = instance.GetStudentDictionary();

            studentDict.Add("Zema Batirov", new Student("Zema", "Batirov", 3, "I23", "Math"));

            Console.WriteLine($"Elements in list: {studentDict.Count}");

            foreach (var item in studentDict)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Enter FName and LName for sarching");

            var studentToFind = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            if (studentDict.TryGetValue(studentToFind, out Student keyStudent))
            {
                Console.WriteLine($"Serch info:");

                Console.WriteLine(keyStudent);
            }

            else
            {
                Console.WriteLine($"Student is not found.");
            }
        }
    }
}
