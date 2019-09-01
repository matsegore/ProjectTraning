using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.EmployeeLINQ_lambda
{
    class CollectionManagement
    {
        public void Execute()
        {

            var employees = Employee.GetEmployees();

            var sortedEmployeesLastName = employees.OrderBy(employee => employee.LastName);

            Console.WriteLine("Sorted employees with a last name");

            Display(sortedEmployeesLastName);

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesAge = employees.Where(employee => employee.Age > 30)

                                              .OrderBy(employee => employee.Age);

            Console.WriteLine("Sorted employees with age");

            Display(sortedEmployeesAge);

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesMGender = employees.Where(employee => employee.Gender == "M");

            var sortedEmployeesFGender = employees.Where(employee => employee.Gender == "F");

            Console.WriteLine("Sorted employees with gender (M)");

            Display(sortedEmployeesMGender);

            Console.WriteLine("Sorted employees with gender (F)");

            Display(sortedEmployeesFGender);

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesFullName = employees.Select(employee => employee.LastName + " " + employee.FirstName);

            Console.WriteLine("Employees only with a full name");

            foreach (var item in sortedEmployeesFullName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesWomenNameWithO = employees.Where(employee => employee.Gender == "F"

                                                                         && employee.LastName.StartsWith("O")

                                                                         && employee.Age > 20);

            Console.WriteLine("Sorted employees with a last name with \"O\"");

            var selectedEmployees = sortedEmployeesWomenNameWithO.Select(employee => employee.LastName);

            foreach (var item in selectedEmployees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesOfCompany = employees.GroupBy(employee => employee.Company)

                                                    .Select(employee => employee.Key + " - " + employee.Count() + " person(s) in the company.");

            Console.WriteLine("Sorted employees of a company:");

            foreach (var item in sortedEmployeesOfCompany)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesFirstEmployee = employees.First();

            Console.WriteLine("The first employee on the list is:");

            Console.WriteLine(sortedEmployeesFirstEmployee.ToString());

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesLastEmployee = employees.Last();

            Console.WriteLine("The last employee on the list is:");

            Console.WriteLine(sortedEmployeesLastEmployee.ToString());

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesLastEmployeeWithAge25 = employees.Where(employee => employee.Age > 25);

            var sortedEmployee = sortedEmployeesLastEmployeeWithAge25.First();

            Console.WriteLine("The first employee with age > 25 on the list is:");

            Console.WriteLine(sortedEmployee.ToString());

            Console.WriteLine(Environment.NewLine);

            var sortedEmployeesPupil = employees.Where(employee => employee.FirstName == "Oleg")

                                                .Select(pupil => new Pupil(pupil.FirstName, pupil.LastName, "School 82"));
          
            Console.WriteLine("Sorted employees with a first name 'Oleg' and new pupil");

            foreach (var item in sortedEmployeesPupil)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

        }

        public void Display(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", item.LastName, item.FirstName, item.Age, item.Gender, item.Company);

                Console.WriteLine("----------------------------------------");
            }

        }
    }
}
