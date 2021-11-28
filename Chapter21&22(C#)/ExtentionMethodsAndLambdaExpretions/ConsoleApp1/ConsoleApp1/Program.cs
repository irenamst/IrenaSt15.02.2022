using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    public static class EnumerableExtentions
    {
        public static string ToString<T>(this IEnumerable<T> enumration)
        {
            StringBuilder result = new StringBuilder();

            result.Append("[");

            foreach (var item in enumration)
            {
                result.Append(item.ToString());
                result.Append(","); 
            }


            if (result.Length > 1)
            
                result.Remove(result.Length - 2, 2);
            

            result.Append("]");

            return result.ToString();
        }
    }
    public static class IListExtentions
    {
        public static void IncreaseWidth(this IList<int> list,int amount)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] + amount;
            }
        }
    }
    public static class StringExceptions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ',',','.','!','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            string helloString = "Hello, Extention Methods!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);

            List<int> numbers=new List<int> {1,2,3,4,5 };
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWidth(5);
            Console.WriteLine(numbers.ToString<int>());
        }
    }
}
