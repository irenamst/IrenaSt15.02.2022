using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Color = "Red", Brand = "BMW", Speed="180"};
            Console.WriteLine($"My car is {myCar.Color} {myCar.Brand}.");
            Console.WriteLine($"It runs {myCar.Speed} km/h.");
            Console.WriteLine($"ToString: {myCar.ToString()}");
            Console.WriteLine($"Hash code: {myCar.GetHashCode().ToString()}");
            Console.WriteLine("Equals? {0}", myCar.Equals(new {Color="Red",Brand="BMW",Speed="180" }));
            Console.WriteLine("Type name: {0}",myCar.GetType().ToString());
        }
    }
}
