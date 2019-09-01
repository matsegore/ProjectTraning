using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.EmployeeLINQ_lambda
{
    class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Company { get; set; }

        public Employee(string firstName, string lastName, int age, string gender, string company)
        {
            this.FirstName = firstName;

            this.LastName = lastName;

            this.Age = age;

            this.Gender = gender;

            this.Company = company;
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee("Alex", "Levks", 22, "M", "Epam"),

                new Employee("John", "Kek", 44, "M", "Epam"),

                new Employee("Alexis", "Pland", 35, "F", "Epam"),

                new Employee("Dmitriy", "Nazar", 31, "M", "Intetics"),

                new Employee("Pip", "Crash", 38, "M", "Intetics"),

                new Employee("Vaza", "Marumov", 31, "M", "Intetics"),

                new Employee("Tatti", "Kalinsky", 21, "F", "Intetics"),

                new Employee("Hanna", "Frisk", 21, "F", "Intetics"),

                new Employee("Den", "Bareb", 22, "M", "Intetics"),

                new Employee("Katya", "Kalkins", 24, "F", "Intetics")

            };

        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + ", " + this.Age + ", " + this.Gender + ", " + this.Company;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                Employee emp = (Employee)obj;

                return (FirstName == emp.FirstName) && (LastName == emp.LastName) && (Age == emp.Age) && (Gender == emp.Gender) && (Company == emp.Company);
            }
        }

        public override int GetHashCode()
        {
            return (2 * 5) ^ 2;
        }
    }
}
