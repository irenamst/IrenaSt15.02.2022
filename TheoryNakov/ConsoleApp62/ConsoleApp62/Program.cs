using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        /// <summary>
        /// Finds primes from a range [start...end] and returns them in a list
        /// </summary>
        /// <param name="start">Top of range</param>
        /// <param name="end">End of range</param>
        /// <returns>A list of all the found primes</returns>
        public static List<int> FindPrimes(int start,int end) 
        { 
            List<int> primeList = new List<int>();
            for (int num = start; num <= end; num++) {
                bool isPrime = IsPrime(num);
                if (isPrime)
                {
                    primeList.Add(num);
                }
            }
            return primeList; 
        }
        public static bool IsPrime(int number)
        {
            for (int div = 2; div <= Math.Sqrt(number); div++)
            {
                if(number % div == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
        }
    }
}
