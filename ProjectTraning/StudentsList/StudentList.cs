using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.StudentList
{
    class StudentList
    {
        private List<Student> studentList = new List<Student> {

            new Student ("Adam", "Potter", 4, "Z67", "Сhemistry"),

            new Student ("Alex", "Smith", 3, "L11", "Math"),

            new Student ("James", "Bond", 2, "P43", "Med")
        };

        public List<Student> GetStudentList()
        {
            return studentList;
        }
    }
}