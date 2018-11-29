using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice invoice1 = new Invoice("part123", "jacket", 2, 35.99M);
            Console.WriteLine("default invove info");
            Console.WriteLine("part no: {0}", invoice1.PartNo);
            Console.WriteLine("Item Description {0}", invoice1.Description);
            Console.WriteLine("item quantity " + invoice1.Quantity);
            Console.WriteLine("the price per unit is: {0:C}" , invoice1.Price);

            Console.WriteLine("Total ammount is {0:C} ",  invoice1.getInvoiceAmmount());


     
            




        }
    }
}
