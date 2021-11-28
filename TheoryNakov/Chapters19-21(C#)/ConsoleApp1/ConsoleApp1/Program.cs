// See https://aka.ms/new-console-template for more information

int m = 4;
double Su(int number)
{
    m = 5;
    return Math.Sqrt(number * m);
}
Console.WriteLine("Hello, World!"+Su(3));
