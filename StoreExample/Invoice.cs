using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    public class Invoice
    {
        //private variables
        //can auto implement this one as we dont need access to this to modify it-actually we don need a private variable
       // private string partNo;
        //can auto implement this one as we dont need access to this to modify it-actually we don need a private variable
        //private string description;
        //these 
        private int quantity;
        private decimal price;


        //constructor
        public Invoice(string part, string desc, int qty, decimal price)
        {
            PartNo = part;
            Description = desc;
            Quantity = qty;
           Price = price;

        }


        //auto implmented public property as we shouldnt really need to 
        public string PartNo {
            get;
            set;

            }
        //auto implmented property
        public string Description
        {
            get;
            set;
        }

        //public property for quantity

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >=0)
                { quantity = value; }

            }

        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0M)
                { price = value; }

            }

        }

        public decimal getInvoiceAmmount()
        {
            return (Price * Quantity);
        }
     


        }
}
