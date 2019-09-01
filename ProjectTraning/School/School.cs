using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.School
{
    class SchoolInfo
    {
        public  void Execute()
        {
            Pupil[] pupils =
            {
                new Pupil("Alex", "Juk", 2003, 11, "9-A"),

                new Pupil("Dima", "Kolitov", 2004, 4, "8-Б"),

                new Pupil("Jhon", "Bond", 2004, 3, "8-A"),

                new Pupil("Zema", "Kilov", 2004, 2, "8-В")

            };

            for (int i = 0; i < pupils.Length; i++)
            {
                if (i == 0)
                {
                    pupils[i].DisplayAliases();
                }

                pupils[i].DisplayTable();
            }

        }
    }
}
