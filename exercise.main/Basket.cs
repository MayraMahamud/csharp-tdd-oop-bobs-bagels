using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();


        public int MaximumCapacity { get => maximumCapacity; set => maximumCapacity = value; }
        // public List<string> Items { get { return _items; } }
        public int maximumCapacity = 2;





        public void AddProduct(IProduct product)
        {

            _products.Add(product);
        }


        public string RemoveProduct(IProduct product)
        {



            if (!_products.Contains(product))
            {
                return "Item does not exist";
            }
            _products.Remove(product);

            return string.Empty;


            _products.Remove(product);
        }

        public decimal GetTotalCost()
        {

            return _products.Sum(p => p.Price);
        }

        public bool IsBasketFull()
        {
            if (_products.Count == maximumCapacity)
            {

                return true;
            }
            return false;
        }


        public void ChangeCapacity(Manager manager, int newCapacity)
        {

            if (manager.Role != "Manager")
            {
                throw new UnauthorizedAccessException("Only managers can change capacity");
            }
            if (newCapacity < _products.Count)
            {
                Console.WriteLine("Capacity is changed");
                return;

            }

        }




        public decimal CostOfBagel(decimal price, IProduct product)
        {
            string Name;
            decimal Price;
            price = product.Price;


            return price;
        }




        public void AddToBagel(Bagel bagels, IProduct filling)
        {
            _products.Add(filling);
        }




        public void ChooseFilling(Bagel bagel, IProduct filling)
        {

            bagel.AddToBagel(filling);


            Console.WriteLine("Filling added");

        }


      


        public Dictionary<string, decimal> GetFillingCost(decimal price)
        {
            Dictionary<string, decimal> fillingCost = new Dictionary<string, decimal>();
            foreach (var filling in _products)
            {
                fillingCost[filling.Name] = filling.Price;

            }
            return fillingCost;

        }






        public List<IProduct> Products { get { return _products; } }


        public Dictionary<string, decimal> GetBagelCost()
        {
            Dictionary<string, decimal> bagelCost = new Dictionary<string, decimal>();
            foreach (var bagels in _products)
            {
                bagelCost[bagels.Name] = bagels.Price;

            }
            return bagelCost;

        }

        public bool IsProductFromInventory(IProduct product, string productName)
        {

           

            return _products.Any(p => p.Name == productName);


        }
        public bool OrderProductFromStock(string productName)
        {
            
          var product = _products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                Console.WriteLine($"Product '{productName}' is ordered");
               
             
            }return true;
            

        }


    }
}

