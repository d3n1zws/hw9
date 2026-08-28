namespace ConsoleApp2
{
    internal class Circle:Shape
    {
        public int Radius;
        public Circle(string color, int radius):base(color)
        {
            Radius = radius;
            Area = radius * radius * 3;
        }
        public void PrintArea()
        {
            Console.WriteLine(Area);
        }

    }
}
