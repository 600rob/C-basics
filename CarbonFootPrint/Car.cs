using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint

    /*
     *for this class we need to set up a few properties which can be used to set the 
     * fuel capacity of the car and also get them if needed. 
     * we also need a method for caclulating the carbon footprint
     * 
     */
{
    class Car : ICarbonFootprint
    {
        //constructor
        public Car(int tanksize)
        {
            FuelCapacity = tanksize;
        }

//private variable needed for accessor and modifier
        private int fuelcapacity;

        //public variable for constructor * uses private variable to set and get values

        public int FuelCapacity
        {
            get
            {
                return fuelcapacity;
            }

            set
            {
                if (value >= 0)
                { fuelcapacity = value; }
            }
        }

           //method to calculate the carbon foor print on a car object

            public void GetCarbonFootPrint()
        {
            Console.WriteLine("This vehicle has a tak size of {0}, its carbon foot print is {1}",
                FuelCapacity, FuelCapacity*20);
        }
        }


}

