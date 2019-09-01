using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task1
{
    class Execute
    {
        public  void SalaryAndAge()
        {
            User user1 = new User("Alex", 19);

            User user2 = new User("John", 22);

            Worker worker1 = new Worker("Vasya", 35, 2323.00m);

            Worker worker2 = new Worker("Vova", 20, 21210.00m);

            int sumAge = worker1.Age + worker2.Age;

            decimal sumSalary = worker1.Salary + worker2.Salary;

            Student student1 = new Student("Vlad", 36, 3333.00m, 3);

            Student student2 = new Student("Dima", 22, 2222.00m, 3);

            Driver driver1 = new Driver(2.5, DriverLicenceCategories.A, "Kirill", 26, 10800.00m);

            Driver driver2 = new Driver(5, DriverLicenceCategories.C, "Lesha", 33, 12300.00m);

            Console.WriteLine($"Sum of salary: {sumSalary}");

            Console.WriteLine($"Sum of age: {sumAge}");

            Console.WriteLine($"Scholarship of {student1.Name} is {student1.Scholarship}. He's/She's {student1.Course} year student.");

            Console.WriteLine($"The scholarship of {student2.Name} is {student2.Scholarship}. He's/She's {student2.Course} year student.");

            Console.WriteLine($"The driver {driver1.Name} has '{driver1.DriverLicence}' category and {driver1.DriverExperience} years of driver experience.");

            Console.WriteLine($"The driver {driver2.Name} has '{driver2.DriverLicence}' category and {driver2.DriverExperience} years of driver experience.");

        }
    }
}
