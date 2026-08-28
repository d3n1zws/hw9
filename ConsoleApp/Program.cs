using ConsoleApp;

Console.WriteLine("say daxil edin");
int n = int.Parse(Console.ReadLine());
Book[] arr = new Book[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"kitab {i+1}:");
    Console.WriteLine("name:");
    string name = Console.ReadLine();
    Console.WriteLine("price:");
    double price = double.Parse(Console.ReadLine());
    Console.WriteLine("count:");
    int count = int.Parse(Console.ReadLine());
    Console.WriteLine("genre:");
    string genre = Console.ReadLine();
    Book book = new Book(name, price, count, genre);
    arr[i] = book; 
}
Console.WriteLine("1.Kitablari qiymete gore filterle");
Console.WriteLine("2.Butun kitablari goster");
Console.WriteLine("0.Proqrami bagla");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (arr[j].Price > arr[j + 1].Price)
        {
            Book k = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = k;
        }
    }
}
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
        break;
    if (x == 2)
    {
        for (int i = 0; i < n;i++)
        {
            arr[i].Detail();
        }
    }
    else
    {
        double m = int.Parse(Console.ReadLine());
        Console.WriteLine("ala bileceyeniz kitablar:");
        for (int i = 0; i < n; i++)
        {
            if (arr[i].Price < m)
            {
                Console.WriteLine(arr[i].Name);
            }
        }
    }
}
