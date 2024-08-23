using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Coffee : IProduct
    {
        public decimal Price { get; set; }
        public string Variant { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }


    }
}
