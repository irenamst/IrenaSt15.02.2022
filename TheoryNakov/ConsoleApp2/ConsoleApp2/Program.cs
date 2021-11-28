using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
    public static class IListExtentions
    {
        public static void IncreaseWith(this IList<int> list,int amount)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] + amount;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
