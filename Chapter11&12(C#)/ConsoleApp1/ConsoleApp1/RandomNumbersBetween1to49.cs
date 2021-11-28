using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersBetween1to49
{
    internal class RandomNumbersBetween1to49
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int number=1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }
        }
    }
}
