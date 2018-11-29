using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PartTimeEmployee : Employee
    {
        //constructor

            public PartTimeEmployee(string firstname, string lastname,string phoneno, decimal rate)
            :base(firstname, lastname,phoneno)
        {
            HourlyRate = rate;



        }

  
  
        //auto implement propertiy
        public decimal HourlyRate
        {
            get;
            set;

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override void RunPayroll()
        {
            Console.WriteLine( FirstName+"'s rate is {0:c}", HourlyRate);
        }


    }
}
