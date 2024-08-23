using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        private List<IProduct> _products = new List<IProduct>();
        //public decimal Price { get; set; }
        //public string Variant { get; set; }

        //public List<Bagels> bagels;
        //public List<Coffee> coffee;
        //public List<Fillings> fillings;
        public List<IProduct> Products { get { return _products; } }

        public Inventory()
        {
            _products.Add(new Bagel() { Name = "Bagel", Price = 0.49M, SKU = "BGLO", Variant = "Onion" });
            _products.Add(new Bagel() { Name = "Bagel", Price = 0.39M, SKU = "BGLP", Variant = "Plain" });
            _products.Add(new Bagel() { Name = "Bagel", Price = 0.49M, SKU = "BGLE", Variant = "Everything" });
            _products.Add(new Bagel() { Name = "Bagel", Price = 0.49M, SKU = "BGLS", Variant = "Sesame" });
            _products.Add(new Coffee() { Name = "Coffee", Price = 0.99M, SKU = "COFB", Variant = "Black" });
            _products.Add(new Coffee() { Name = "Coffee", Price = 1.19M, SKU = "COFW", Variant = "White" });
            _products.Add(new Coffee() { Name = "Coffee", Price = 1.29M, SKU = "COFC", Variant = "Capuccino" });
            _products.Add(new Coffee() { Name = "Coffee", Price = 1.29M, SKU = "COFL", Variant = "Latte" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILB", Variant = "Bacon" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILE", Variant = "Egg" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILC", Variant = "Cheese" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILX", Variant = "Cream Cheese" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILS", Variant = "Smoked Salmon" });
            _products.Add(new Fillings() { Name = "Filling", Price = 0.12M, SKU = "FILH", Variant = "Ham" });





        }

      

        public Dictionary<string, decimal> GetFillingCost()
        {
            Dictionary<string, decimal> fillingCost = new Dictionary<string, decimal>();
            foreach (var filling in _products)
            {
                fillingCost[filling.Name] = filling.Price;

            }
            return fillingCost;

        }

        public decimal GetFillingPrice(string sku)
        {
            return _products.Where(b => b.SKU == sku).First().Price;

        }

      }
}

    



