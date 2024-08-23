using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Fillings : IProduct
    {
       

        public decimal Price { get; set; }
        public string Variant { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }


        public Fillings()
        {
            
        }

        public Fillings(string name, decimal price)
        {
            Name = name;
            Price = price;

        }
       






       

    }


    
}

