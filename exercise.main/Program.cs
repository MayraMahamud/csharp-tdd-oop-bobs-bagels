// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using exercise.main;
class program 

{
    static void Main(string[] args)
    {
        Receipts receipt = new Receipts("Bobs Bagels");
        receipt.AddItem(new Item("onion Bagel", 2, 0.49));
        receipt.AddItem(new Item("plain Bagel", 12, 0.33));
        receipt.ApplyDiscount(0.10);
        receipt.Print();



    }
}
