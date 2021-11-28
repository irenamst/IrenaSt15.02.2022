using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void PrintList(IList <int> list)
        {
            Console.Write("{ ");
            foreach(int item in list)
            {
                Console.Write(item);

                Console.Write(" ");

            }

            Console.Write(" }");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);
            IList<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);
            List<int> unionList=new List<int>();
            unionList.AddRange(firstList);
            unionList.AddRange(secondList);
            Console.Write("union=");
            PrintList(unionList);

        }
    }
}
