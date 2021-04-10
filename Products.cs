namespace Store
{
    class Products
    {
        public string Name;
        public double Price;
        public int Amount;

        public Products()
        {

        }

        public Products(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
            Amount = 5;
        }

        public double TotalValueInStock()
        {
            return Price * Amount;
        }

        public void AddProduct(int amount)
        {
            Amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Price:F2}, {Amount} units, Total: $ {TotalValueInStock():F2}";
        }
    }
}
