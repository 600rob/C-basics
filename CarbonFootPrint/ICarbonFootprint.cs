using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    interface ICarbonFootprint
    {
        // this is the method that allows us to call on our objects. * the method delcared in the interface
        //does not have an access modifier and it does not need any implementation code. Implementation is written in each calling class
         
        void GetCarbonFootPrint();

    }
}
