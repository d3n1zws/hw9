namespace ConsoleApp2
{
    internal class Shape
    {
        public string Color;
        public int Area;
        public Shape(string color)
        {
            Color = color;
        }
        public void GetInfo()
        {
            Console.WriteLine($"color : {Color}");
            Console.WriteLine($"area : {Area}");
        }
    }
}
