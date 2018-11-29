using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //set some employee vatiable that we can pass to the constructors


            //employee 1

            string firstname = "homer";
            string lastname = "simpson";
            string phoneno = "02078970111";
            decimal salary = 50000M;
            int vacationdays = 25;

            Employee FT1 = new FullTimeEmployee("homer", "simpson", "8082546085", 50000M, 25);

            Console.WriteLine(FT1.ToString());
            FT1.RunPayroll();


            //employee 2

            string firstname1 = "bart";
            string lastnam1e = "simpson";
            string phoneno1 = "02078970112";
            decimal rate = 25m;
            int vacationdays1 = 5;

            PartTimeEmployee PT1 = new PartTimeEmployee("bart","simpson", "808256999", 15.00M);
            

          PT1.RunPayroll();
        }
    }
}
