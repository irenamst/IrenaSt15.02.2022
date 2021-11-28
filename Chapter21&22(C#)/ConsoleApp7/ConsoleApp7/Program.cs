using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulgarianNumbers=new Dictionary<int, string>();
            bulgarianNumbers.Add(1, "едно");
            bulgarianNumbers.Add(2, "две");
            foreach (var pair in bulgarianNumbers.ToArray())
            {
                Console.WriteLine($"pair:[{pair.Key},{pair.Value}]");
            }
        }
    }
}
