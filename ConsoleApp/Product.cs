namespace ConsoleApp
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public void Detail()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Count);
        }
        public void Discount(int n)
        {
            double x = Price * (100 - n) / 100;
            Console.WriteLine(x);
        }

    }
}
