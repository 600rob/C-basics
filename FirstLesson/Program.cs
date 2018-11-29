
//using statments are libraries the project references from the dot net frame work
//simmilar to how we import classes and utilities in java
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//name space always matches the name that we give to our project
namespace FirstLesson
{
    //every project needs a class as the entry point in order to run. It needs a main method as the entry point
    class Program
    {
        static void Main(string[] args)
        {

            string name = "July Quarterly Report";
            string date = "July";
            string type = "quarterlty";

            Report myReport = new Report(name, date, type);

            myReport.ReportType();


            int Number0 = 50;
            int Number1 = 100;
            int Number2 = 150;
            int Number3 = 200;
            bool quizAnswer = true;
            // char is a single character value and are dnoted but single quotes
            char Letter = 'A';
          
            //decimals must  be suffixed with M
            decimal DecimmalNumber = 5.5M;
            string Name = "bob";
            //check out format specifiers to change our output types
            //Console.WriteLine("the man named {0} is {1} years old", Name, Number);

            Console.WriteLine("first number is " + Number0 + " second number is " + Number1 +
                " third number is " + Number2 + " fourth number is "  + Number3);



            Console.WriteLine("first number is {0}" + " second number is {1}" +
                " third number is {2}" + " fourth number is {3}", Number0, Number1,Number2,Number3);

            Console.WriteLine("enter name");
            string userName = Console.ReadLine();


            Console.WriteLine("hello " + userName);






        }
    }
}
