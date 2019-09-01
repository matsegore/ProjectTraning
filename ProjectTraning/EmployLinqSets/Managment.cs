using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTraning.EmployeeLINQ_lambda;

namespace ProjectTraning.EmployLinqSets
{
    class Managment
    {
        public void Execute()

        {

            Employee[] employeesList1 =

                {

                new Employee("Alex", "Levks", 22, "M", "Epam"),

                new Employee("John", "Kek", 44, "M", "Epam"),

                new Employee("Alexis", "Pland", 35, "F", "Epam"),

            };

            Employee[] employeesList2 =

                {

                new Employee("Alexis", "Pland", 35, "F", "Epam"),

                new Employee("Dmitriy", "Nazar", 31, "M", "Intetics"),

                new Employee("Pip", "Crash", 38, "M", "Intetics"),

                new Employee("Vaza", "Marumov", 31, "M", "Intetics"),

            };

            IEnumerable<Employee> queryWithDuplicates = employeesList1.Concat(employeesList2);

            Console.WriteLine($"Copy from array2 to array1 with duplicates (4+4): {Environment.NewLine}");

            foreach (var item in queryWithDuplicates)

            {
                Console.WriteLine(item);
            }

            IEnumerable<Employee> queryWithoutDup = employeesList2.Union(employeesList1);

            Console.WriteLine($"{Environment.NewLine}Copy from array1 to array2 without duplicates: {Environment.NewLine}");

            foreach (var item in queryWithoutDup)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{Environment.NewLine}Duplicates in the lists: {Environment.NewLine}");

            IEnumerable<Employee> queryOfDuplicates = employeesList2.Intersect(employeesList1);

            foreach (var item in queryOfDuplicates)
            {
                Console.WriteLine(item);
            }

            List<Employee> employeesFromArrayToList = employeesList1.ToList();

            employeesFromArrayToList.Add(new Employee("Kirill", "Reshetilo", 20, "F", "Intetics"));

            Console.WriteLine($"{Environment.NewLine}New list with a new element: {Environment.NewLine}");

            foreach (var item in employeesFromArrayToList)

            {

                Console.WriteLine(item);

            }

        }
    }
}
