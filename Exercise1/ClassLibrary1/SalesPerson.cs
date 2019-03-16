using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string first, string last)
        {

            FirstName = first;
            LastName = last;
            Salary = 500;
            Role = Role.Sales;
        }

        public void AddSuccessRevenue(double num)
        {
            SuccessSaleRevenue = num;

        }

        public override double GetSalary()
        {
            //logic
            if (SuccessSaleRevenue <= 2000)
            {

                return Salary = 500;
            }

            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {

                return Salary = 1000;
            }
            else
            {

               return  Salary = 1500;
            } 
            

        }

    }
}
