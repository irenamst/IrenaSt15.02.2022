using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ConsoleApp17
{
    public class PersonData
    {

    }
    internal class Program
    {
        public int Archive(PersonData user, bool person)
        {
            if (user == null)
            {
                throw new ArgumentException
                    ("Невалидни аргументи. Нулеви стойности.");
            }
            int resultFromProcedure = 1;
            //System.Diagnostics;
            Debug.Assert(resultFromProcedure >= 0,"resultFromProcessing is negative. There is a bug");

            return resultFromProcedure;
        }
        static void Main(string[] args)
        {
        }
    }
}
