using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {

            Console.WriteLine($"FirstName: {FirstName}, LastName:{LastName}, Salary:{Salary}");
        }

        public virtual double GetSalary()
        {

            return Salary;
        }
              

    }

    public enum Role { Sales, Manager, Other };
}
