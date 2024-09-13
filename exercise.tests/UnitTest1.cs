using exercise.main;
using System.Reflection.Emit;

namespace exercise.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelToBasketTest()
    {
        Inventory inventory = new Inventory();
        Basket basket = new Basket();

        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLO").First();
        basket.AddProduct(bagel);

        Assert.That(basket.Products.Count, Is.EqualTo(1));
    }



    [Test]
    public void GetTotalCostTest()
    {

        Inventory inventory = new Inventory();
        Basket basket = new Basket();

        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLO").First();
        basket.AddProduct(bagel);

        Assert.That(basket.GetTotalCost(), Is.EqualTo(0.49M));





    }

    [Test]
    public void RemoveBagelFromBasketTest()

    {
        Basket basket = new Basket();
        Inventory inventory = new Inventory();

        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLO").First();
        basket.AddProduct(bagel);


        basket.RemoveProduct(bagel);


        Assert.That(basket.Products.Count, Is.EqualTo(0));
    }

    [Test]
    public void IsBasketFullTest()
    {
        //arrange
        Basket basket = new Basket();
        Inventory inventory = new Inventory();


        //act
        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLO").First();
        IProduct coffee = inventory.Products.Where(b => b.SKU == "COFB").First();


        basket.AddProduct(bagel);
        basket.AddProduct(coffee);



        Assert.That(basket.Products.Count, Is.EqualTo(basket.MaximumCapacity));

        Assert.That(basket.IsBasketFull(), Is.True);
    }

    [Test]
      public void ChangeCapacityTest()
      {
        Manager manager = new Manager();
        manager.Role = "Manager";
          Basket basket = new Basket();
          int firstCapacity = 2;

        basket.ChangeCapacity(manager, firstCapacity);

        Assert.That(basket.MaximumCapacity, Is.EqualTo(firstCapacity));




      }


    [Test]
    public void RemoveNonExistingTest()

    {
        //arrange
        Basket basket = new Basket();
        Inventory inventory = new Inventory();


        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLO").First();
        IProduct coffee = inventory.Products.Where(b => b.SKU == "COFB").First();
        IProduct filling = inventory.Products.Where(b => b.SKU == "FILE").First();

        basket.AddProduct(bagel);
        basket.AddProduct(coffee);


        //act
        string results = basket.RemoveProduct(filling);



        //assert
        Assert.That(results.Length > 0);

    }

    [Test]

    public void CostOfBagelTest()
    {
        //arrange
        Inventory inventory = new Inventory();
        Basket basket = new Basket();
       Bagel plainBagel = new Bagel("Plain", 0.39M);
      

        //act
        IProduct bagel = inventory.Products.Where(b => b.SKU == "BGLP").First();
        basket.AddProduct(plainBagel);



        //assert 
        Assert.That(plainBagel.Price, Is.EqualTo(bagel.Price));
            
      

    }

    [Test]

    public void ChooseFillingTest()
    {
        //arrange
        Inventory inventory = new Inventory();
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
  

        //act
        IProduct filling = inventory.Products.Where(b => b.SKU == "FILE").First();

        bagel.AddToBagel(filling);
        basket.AddProduct(bagel);


        //assert 
       Assert.That(basket.Products.Count, Is.EqualTo(1));

        //  Assert.That(basket.ChooseFilling, Is.EqualTo());

    }

    [Test]

    public void GetFillingCostTest()
    {
        //arrange
        Basket basket = new Basket();
        Inventory inventory = new Inventory();
        Fillings egg = new Fillings("Egg", 0.12M);
       

        //act
        Dictionary<string, decimal> fillingCost = inventory.GetFillingCost();
        IProduct filling = inventory.Products.Where(b => b.SKU == "FILE").First();
        




        //assert 
        
        Assert.That(filling.Price, Is.EqualTo(egg.Price));
             

    }




    [Test]

    public void OrderProductFromStock()
    {
        //arrange
        Inventory inventory = new Inventory();
        Basket basket = new Basket();
        basket.AddProduct(new Bagel("Plain", 0.39M));

        //act
        bool result = basket.OrderProductFromStock("Plain");

        //assert
        Assert.That(result, Is.True);
         

    }
    

    


}






