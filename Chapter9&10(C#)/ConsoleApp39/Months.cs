using System;

namespace ConsoleApp39
{
    class Months
    {
        static string GetMonth(int month)
        {
            string monthName;
            switch(month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    return null;
            }
            return monthName;
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period = period + 12;
            }
            Console.WriteLine("There is a {0} months period from {1} to {2}.", period, GetMonth(startMonth), GetMonth(endMonth));
        }
        static void Main(string[] args)
        {
            Console.Write("First month(1-12):");
            int firstMonth = int.Parse(Console.ReadLine());
            Console.Write("Second month(1-12)");
            int secondMonth = int.Parse(Console.ReadLine());
            SayPeriod(firstMonth, secondMonth);
        }
    }
}
