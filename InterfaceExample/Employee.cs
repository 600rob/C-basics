using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Employee
    {// this is our base class, abstract means we can not directly insatiate an Employee object. We do this through our derived classes
        //Abstract class usually contains one or more abstact methods. The can also contain some concrete ones

        //constructor

            public Employee(string firstname, string lastname, string phoneno)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNo = phoneno;

        }



        //auto implemented properties.

        public string FirstName
        {
            get;
            set;
        }



        public string LastName
        {
            get;
            set;
        }



        public string PhoneNo
        {
            get;
            set;
        }


        //abstract method
        //this is the same idea as an abstract class where we have a method with no code implementation. 
        //each derrived class must contain its own implementation of the abstract method using the ovveride command
        public abstract void RunPayroll();
    }
}
