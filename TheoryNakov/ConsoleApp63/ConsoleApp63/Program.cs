using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    internal class Program
    {
        static long Sum(int[] numbers)
        {
            long sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
              int[] masive1 = new int[] { 1, 2 };
              if (Sum(masive1) != 3)
              {
                  throw new Exception("(1+2)!=3");
              }
              int[] masive2 = new int[] { 1 };
              if(Sum(masive2) != 1)
              {
                  throw new Exception("Sum of 1!=1");
              }
            
            int[] masive3=new int[] {};
            if(Sum(masive3) != 0)
            {
                throw new Exception("Sum of 0 numbers!=0");
            }
            
            int[] masive4 = new int[] { -1, -2 };
            if (Sum(masive4) != -3)
            {
                throw new Exception("(-1)+(-2)!=-3");
            }
            try
            {
                Sum(null);
                //An exception is expected->
                //the test fails
                throw new Exception("Null array cannot be summed");
            }
            catch (NullReferenceException)
            {
                //NullReferenceException is expected->the test passes
            }
        }
    }
}
