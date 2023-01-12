using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_1.products
{
    public class Products
    {
        
        public string Productname { get; set; }
        public decimal Productprice { get; set; }
        public int Raodenoba { get; set; }
       // public DateTime Dateofissue { get; set; }



        public Products(string productname, decimal productprice, int raodenoba)
        {
            Productname = productname;
            Productprice = productprice;
            Raodenoba = raodenoba;
            //Dateofissue = dateofissue;


        }

        public Products()
        {
        }
    }
}
