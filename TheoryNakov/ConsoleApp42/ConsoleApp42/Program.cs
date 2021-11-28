using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        public static int CalcAverageResults(int days, int hoursPerDay, int ratePerHour)
        {
            int salary = 0;
            if(days >0 && days<31 && hoursPerDay>0 && hoursPerDay<8 && ratePerHour > 0)
            {
                salary = days * hoursPerDay * ratePerHour;
            }
            return salary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalcAverageResults(3, 3, 3));
        }
    }
}
