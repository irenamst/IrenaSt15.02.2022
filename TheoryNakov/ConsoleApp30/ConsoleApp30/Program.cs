using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Guid> set = new HashSet<Guid>();
            for(int i = 0; i < 50000; i++)
            {
                set.Add(Guid.NewGuid());//Add random Guid
            }
            Guid KeyForSearching = new Guid();
            DateTime startTime = DateTime.Now;
            for(int i = 0; i < 50000; i++)
            {
                //Use Hashset.Contains(...)
                bool found =set.Contains(KeyForSearching);
            }
            Console.WriteLine("HashSet: {0}",DateTime.Now - startTime);
            startTime = DateTime.Now;
            for(int i = 0; i < 50000; i++)
            {
                //Use Ienumerable<Guid>.Contains(...) extension method
                bool found = set.Contains<Guid>(KeyForSearching);
            }
            Console.WriteLine("Contains:{0}",DateTime.Now-startTime);
        }
    }
}
