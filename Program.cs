using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Products prod = new Products();

            Console.WriteLine("Enter product date:");
            Console.Write("Name: ");
            prod.Name = Console.ReadLine();
            Console.Write("Price: ");
            prod.Price = double.Parse(Console.ReadLine());
            Console.Write("Amount in stock: ");
            prod.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Product Data: {prod}");

            Console.WriteLine();
            Console.Write("Type the number of products to be added to stock: ");
            int amt = int.Parse(Console.ReadLine());
            prod.AddProduct(amt);

            Console.WriteLine();
            Console.WriteLine($"Updated Data: {prod}");

            Console.Write("Type the number of products to be removed from stock: ");
            amt = int.Parse(Console.ReadLine());
            prod.RemoveProduct(amt);

            Console.WriteLine();
            Console.WriteLine($"Updated Data: {prod}");
        }
    }
}
