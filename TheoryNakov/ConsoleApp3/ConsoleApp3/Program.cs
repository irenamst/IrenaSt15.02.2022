using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class IListExtensions
    {
        public static void IncreaseWight(this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] + amount;
            }
        }
    }
    public static class IEnumerableExtentions
    {
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder result=new StringBuilder();
            result.Append("[");
            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }
            if(result.Length > 1)
            {
                result.Remove(result.Length - 2, 2);
            }
            result.Append("]");
            return result.ToString();
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5};
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWight(5);
            Console.WriteLine(numbers.ToString<int>());
        }
    }
}
