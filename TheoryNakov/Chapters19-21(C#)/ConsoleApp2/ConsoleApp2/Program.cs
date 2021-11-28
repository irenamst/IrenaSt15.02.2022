// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/// <summary>Finds primes from a range [start…end] and returns them 
/// in a list.</summary>
/// <param name="start">Top of range</param>
/// <param name="end">End of range</param>
/// <returns>A list of all the found primes</returns>
//public List<int> FindPrimes(int start, int end)
//{ … }

static int Sum(int[] numbers)
{
    int sum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
static void Main(string[] args)
{
    Console.WriteLine("Hello, Irena!");
    if (Sum(new int[] { 1, 2 }) != 3)
        throw new Exception("1 + 2 != 3");
}
Main(args);

