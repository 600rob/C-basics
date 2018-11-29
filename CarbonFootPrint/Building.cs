using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
/*
*for this class we need to set up a few properties which can be used to set the 
* area of the building and also get them if needed. 
* we also need a method for caclulating the carbon footprint
* 
*/
{
    class Building : ICarbonFootprint
    {

        //constructor

            public Building (int area)
        {
            SquareFoot = area;
        }

        //private variable for get and set

        private int squarefeet;

        //public int for constuctor * uses private variable to set and get values

        public int SquareFoot
        {
            get
            {
                return squarefeet;
            }


            set
            {
                if (value >=0)
                { squarefeet = value;}
            }


        }

        public void GetCarbonFootPrint()
        {
            Console.WriteLine("this building has an area of {0}, its carbon foot print is {1}",
                SquareFoot, SquareFoot * 134);
        }



    }
}
