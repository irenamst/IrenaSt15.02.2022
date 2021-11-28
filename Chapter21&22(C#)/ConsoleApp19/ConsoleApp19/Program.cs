using System;
using sysytem.Microsoft;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.NUnit.Framework;
using XUint.Framework;
namespace ConsoleApp19
{
    internal class Sumator_Accessor
    {
        public static long Sum(int[] numbers)
        {
            long sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
    //[TestClass]
    internal class SumatorTest
    {
        //[TestMethod]
        public void SumTestTypicalCase()
        {
            int[] numbers = new int[] { 1, 2 };
            long expected = 3;
            long actual = Sumator_Accessor.Sum(numbers);
            Assert.AreEqual(expected, actual);
        }
        static void Main(string[] args)
        {
        }
    }
}
