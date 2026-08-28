namespace ConsoleApp
{
    internal class Book:Product
    {
        public string Genre;
        public Book(string name, double price, int count, string genre):base(name, price)
        {
            Genre = genre;
            Count = count;
        }
    }
}
