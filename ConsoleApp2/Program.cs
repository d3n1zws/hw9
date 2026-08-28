using Microsoft.VisualBasic.FileIO;

Console.WriteLine("length for rectangle:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("width for rectangle:");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("color for rectangle");
string color = Console.ReadLine();
ConsoleApp2.Rectangle rectangle1 = new ConsoleApp2.Rectangle(length, width, color);
rectangle1.GetInfo();
rectangle1.PrintArea();


Console.WriteLine("radius for circle:");
int radius = int.Parse(Console.ReadLine());
Console.WriteLine("color for circle");
string color2 = Console.ReadLine();
ConsoleApp2.Circle circle = new ConsoleApp2.Circle(color2, radius);
circle.GetInfo();
circle.PrintArea();