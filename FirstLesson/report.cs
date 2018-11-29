using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    class Report
    {
        private string name;
        private string date;

        public Report(string name, string date, string type)

        {
            Name = name;
            Date = date;
            Type = type;


        }
        //Proprty, a property is a public method whic allows us to access and control a private variable. 
        //The Block below for public string name is a property. Note. The get and set accessors are called implicitly
        //when the property is accessed.
        public string Name
        {
            get
            {
                return name;
            }

            set { name = value; }

        }




        public string Date
        {
            get
            {
                return date;

            }

            set
            {
                if (value == "July")
                {
                    date = value;
                }



            }
        }
        //auto implemented proerty
        public string Type
        {

            get;
            set;
        }

        public void ReportType()
        {
            Console.WriteLine("This is a {0} report", Type);


        }

    }

}
