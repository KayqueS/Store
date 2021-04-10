using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product date:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Products prod = new Products(name, price);

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
