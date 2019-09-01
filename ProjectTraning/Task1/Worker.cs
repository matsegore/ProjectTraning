using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task1
{
  class Worker : User
        {
            public decimal Salary { get; set; }

            public Worker(string name, int age, decimal salary)

                : base(name, age)
            {
                Salary = salary;

                Name = name;

                Age = age;
            }
        }
    }

