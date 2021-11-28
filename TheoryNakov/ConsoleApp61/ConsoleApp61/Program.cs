using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    internal class Program
    {
        public static List<int> FindPrimes(int start, int end)
        {
            //Create new list of integers
            List<int> primesList = new List<int>();
            //Perform a loop from start to end
            for(int num = start; num <= end; num++)
            {
                //Declare boolean variable,
                //intially true
                bool prime = true;
                //Perform loop from 2 to sqrt(num)
                for(int div = 2; div <= Math.Sqrt(num); div++)
                {
                    //Check if div divides num with no remainder
                    if (num % div == 0)
                    {
                        //We found a divide->the number is not prime
                        prime = false;
                        //Exit from the loop
                        break;
                    }
                    //Continue with the next loop value
                }

                //Check if the number is prime
                if (prime)
                {
                    //Add the number to the list of primes
                    primesList.Add(num);
                }
            }
            //return the list of primes
            return primesList;
        }
        static void Main(string[] args)
        {
            List<int> a = FindPrimes(2, 20);
            Console.WriteLine(a.ToArray());
        }
            
    }
}
