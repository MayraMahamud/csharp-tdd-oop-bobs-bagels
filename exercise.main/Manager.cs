using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Manager

    {
        public string Name { get; set; }
        public string Role { get; set; }

        //public Manager(string name, string role)
        //{
        //    Name = name;
        //    Role = role;
        //}

        public void ChangeBasketCapacity(Basket basket, int newCapacity)
        {


            basket.maximumCapacity = newCapacity;
        }
    }
}
