using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // this tells us that this class inherits from Employee
    class FullTimeEmployee : Employee
    {
        //constructor note this constructor needs to take the parameters from the base class constuctor as well as it own

            public FullTimeEmployee(string firstname, string lastname, string phoneno, decimal salary, int vacationdays)
            :base(firstname,lastname, phoneno)
        {
            
            SalaryRate = salary;
            VacationDays = vacationdays;
        }



        public decimal SalaryRate
        {
            get;
            set;
        }

        public int VacationDays
        {
            get;
            set;
        }


        public override string ToString()
        {
            return FirstName + " " + LastName + " is full time";
        }


        public override void RunPayroll() {
            Console.WriteLine(FirstName+"'s salary is {0:c}", SalaryRate);
        }


    }
}
