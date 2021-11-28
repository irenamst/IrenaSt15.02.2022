using System;
using System.Threading;
using System.Globalization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2018,05,23,15,30,22);
            Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}",1234.56);
            Console.WriteLine("{0:D}",d);

            Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("{0:N}",1234.56);
            Console.WriteLine("{0:D}",d);
        }
    }
}