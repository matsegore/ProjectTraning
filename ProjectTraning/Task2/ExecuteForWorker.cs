using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task2
{
    class ExecuteForWorker
    {
        public void GetSalaryAndAge()
        {
            Worker worker1 = new Worker("Jenya", 21, 4000.00m);

            Worker worker2 = new Worker("Dima", 23, 5000.00m);

            decimal sumSalary = worker1.Salary + worker2.Salary;

            int sumAge = worker1.Age + worker2.Age;

            Console.WriteLine($"Sum of ages: {sumAge}");

            Console.WriteLine($"Sum of salaries: {sumSalary}");
        }

    }
}

