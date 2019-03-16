using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee() { FirstName = "Bob", LastName = "Bobski", Role = Role.Sales};
            //bob.PrintInfo();

            SalesPerson john = new SalesPerson("John", "Doe");
            john.PrintInfo();
            Console.WriteLine(john.GetSalary());
            john.AddSuccessRevenue(4000);
            Console.WriteLine(john.GetSalary());

            Console.ReadLine();
        }
    }
}
