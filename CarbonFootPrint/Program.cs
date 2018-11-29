using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
    /**
     * create three non related classes wich all use a common interface 
     * to calculate the carbon foot print for each type 
     * */
     
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of ICarbonFootprint, then initalise it with an objet of each type:

            ICarbonFootprint[] vehicleList = new ICarbonFootprint[3];

            vehicleList[0] = new Building(2000);
            vehicleList[1] = new Car(60);
            vehicleList[2] = new Bicycle();


            foreach (ICarbonFootprint item in vehicleList)
            {
               item.GetCarbonFootPrint();

            }
            


        }
    }
}
