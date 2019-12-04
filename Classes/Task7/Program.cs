using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("David", "Bob");
            employee1.EmployeeSalary("Junior", 1.5, 400);

            Employee employee2 = new Employee("Johny", "David");
            employee2.EmployeeSalary("Senior", 6, 2000);

            Console.ReadKey();
        }
    }
}
