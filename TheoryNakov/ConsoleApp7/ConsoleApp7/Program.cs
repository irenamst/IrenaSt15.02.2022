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

            (string FirstName, string LastName, int Age) personInfo = ("Ivan", "Ivanov", 28);
            Console.WriteLine(personInfo);
        }
    }
}
