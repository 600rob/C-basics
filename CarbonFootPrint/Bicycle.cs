using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Bicycle : ICarbonFootprint
    /*
     *bicycle has no carbon foot print so we cont need to set any properties.
     * we can also use the default constructor that comes with .net framework
     * ( we could make our own constructor if necessary but for the purpose of this exersice i will not)
     * ill just create a method tho return a statment
     */
    {
        public void GetCarbonFootPrint()
        {

            Console.WriteLine("Bicycles do not have a carbon foot print!");
        }


    }
}
