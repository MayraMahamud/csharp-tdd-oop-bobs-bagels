using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Receipts
    {
        public string StoreName { get; set; }
        public DateTime PurchaseDate {  get; set; }
        private List<Item> Items { get; } = new List<Item>();   
        public int TotalAmount { get; set; }    
        private double Discount { get; set; } = 0.0;
        public Receipts (/*List<Item> items,*/ string storeName)

        {
            //Items = items;
            PurchaseDate = DateTime.Now;
            StoreName = storeName;
        }

        

        public void AddItem(Item item)
        {
            Items.Add(item);
        }



        public void ApplyDiscount(double discountPercentage)
        {
            Discount  = discountPercentage;

        }

        public void Print()
        {
            Console.WriteLine($"~~~{StoreName}~~~");

            Console.WriteLine(PurchaseDate.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(new string('-', 28));
            foreach (var item in Items) 
            {
                Console.WriteLine($"{item.Name,-17} {item.Quantity,-4} £ {item.TotalPrice:F2}");
            }


            Console.WriteLine(new string('-', 28));
            double total = CalculateTotal();
            double discountedTotal = total * (1-Discount);

            Console.WriteLine($"Total {new string(' ', 17)} £ {total:F2}");
            if (Discount > 0) 
            {
                Console.WriteLine($"Discount({Discount * 100}%) -£{total - discountedTotal:F2}");
                Console.WriteLine($"Final £ {discountedTotal:F2}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Thank you for your order");
            //double total = CalculateTotal();
            //double diccountedTotal = total * (1- Discount); 
            //Console.WriteLine($"Total
        }

        public double CalculateTotal()
        {
            double total = 0.0;
            foreach (var item in Items)
            {
                total += item.TotalPrice;
            }
            return total;
        }
    }
}
