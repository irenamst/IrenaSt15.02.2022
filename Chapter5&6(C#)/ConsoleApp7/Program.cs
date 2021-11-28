using static System.Console;
using static System.Threading.Thread;
using static System.Globalization.CultureInfo;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentThread.CurrentCulture = GetCultureInfo("en-US");
            
            WriteLine("{0:c}",1234.56); //$1,234.56
        }
    }
}
