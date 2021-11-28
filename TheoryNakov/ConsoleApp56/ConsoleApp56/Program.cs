using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        enum Days
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        }
        enum Color
        {
            Black,Red,Green,Blue,Yellow,Orange,Pink,Gray,White
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine(Color.Black);
        }
    }
}
