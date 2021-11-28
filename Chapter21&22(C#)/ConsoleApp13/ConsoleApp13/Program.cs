using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Global
    {
        public static int state = 0;
    }
    public class Genius
    {
        public static void PrintSomething()
        {
            if (Global.state == 0)
            {
                Console.WriteLine("Hello.");
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
