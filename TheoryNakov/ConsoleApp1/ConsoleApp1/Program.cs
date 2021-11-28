using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtentions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ','.','?','!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello, Extention Methods. I am here!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
        }
    }
}
