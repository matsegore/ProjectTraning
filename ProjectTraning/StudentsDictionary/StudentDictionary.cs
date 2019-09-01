using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTraning.StudentList;

namespace ProjectTraning.StudentsDictionary
{
    class StudentDictionary
    {
        private Dictionary<string, Student> studentDict = new Dictionary<string, Student>()
        {
            { "Sasha Grande", new Student("Sasha", "Grande", 4, "E12", "RTM") },

            {"Vasya Bulba" , new Student("Vasya", "Bulba", 4, "P00", "Fly")}

        };

        public Dictionary<string, Student> GetStudentDictionary()
        {
            return studentDict;
        }
    }
}
