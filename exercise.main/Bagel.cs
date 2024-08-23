using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Bagel : IProduct
    {
        private List<IProduct> bagels= new List<IProduct>();
        public decimal Price { get; set; }
        public string Variant { get ; set ; }
        public string SKU { get; set; }
        public string Name { get; set; }

        public Bagel()
        {
            
        }

        public Bagel(string name, decimal price)

        {
            Name = name;
            Price = price;  
        }




        public void AddToBagel( IProduct filling)
        {
            bagels.Add(filling);
        }
    }

   



}


