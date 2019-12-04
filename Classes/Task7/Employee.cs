using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Employee
    {
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;

            job = new Dictionary<string, double>();
            job.Add("Junior", 1.2);
            job.Add("Middle", 1.4);
            job.Add("Senior", 1.6);
        }

        public void EmployeeSalary(string position, double experience, double salary)
        {
            double boost = 0;
            

            if (job.ContainsKey(position))
            {
               boost = job[position] + GetExperienceBoost(experience);
            }

            salary *= boost;
            double tax = salary / 100 * 20;
            

            Console.WriteLine($"Name - {_name} Surname {_surname}");
            Console.WriteLine($"Job {position} ");
            Console.WriteLine($"Salary {salary}");
            Console.WriteLine($"Tax {tax}");

        }

        private double GetExperienceBoost(double experience)
        {
            return experience * 1.1;
        }

        Dictionary<string, double> job; //string position, double salary boost

        private string _name;

        private string _surname;
    }
}
