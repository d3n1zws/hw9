namespace ConsoleApp2
{
    internal class Rectangle:Shape
    {
        public int Length;
        public int Width;
        public Rectangle(int length, int width, string color):base(color)
        {
            Length = length;
            Width = width;
            Area = length * width;
        }
        public void PrintArea()
        {
            Console.WriteLine(Area);
        }
    }
}
