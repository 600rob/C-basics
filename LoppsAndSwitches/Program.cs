using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoppsAndSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int counter = 1;
            int total = 0;

            while (counter <= 5)
            {
                Console.WriteLine("enter a  number");
                value = Convert.ToInt32(Console.ReadLine());
                total = value + total;
                counter++;
            }
            Console.WriteLine(total);



        }
    }
}
