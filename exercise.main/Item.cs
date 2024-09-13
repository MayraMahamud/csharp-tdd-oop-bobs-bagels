using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public  class Item
    {
        public string Name { get; set; }    
        public int Quantity { get; set; }   
        public double PricePerUnit { get; set; }    
        public double TotalPrice => Quantity * PricePerUnit;    
        
        public Item(string name , int quantity, double pricePerUnit) 
        {
            Name = name ;   
            Quantity = quantity ;   
            PricePerUnit = pricePerUnit ;   
        }
    }
}
