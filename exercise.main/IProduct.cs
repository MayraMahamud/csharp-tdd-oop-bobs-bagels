﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public interface IProduct
    {
        decimal Price { get; set; }
        string Variant { get; set; }

        string SKU { get; set; }
        
        string Name { get; set; }   

    }

}   

    

