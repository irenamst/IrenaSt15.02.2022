using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="beer";
            string anotherStr = str;
            Console.WriteLine(str==anotherStr);
            string thirdStr = "bee";
            thirdStr = thirdStr + 'r';
            Console.WriteLine(" str = {0} ", str);
            Console.WriteLine(" anotherStr = {0} ", anotherStr);
            Console.WriteLine(" thirdStr = {0} ", thirdStr);
            Console.WriteLine( str == anotherStr );
            Console.WriteLine( str == thirdStr );
            Console.WriteLine( (object)str == (object)anotherStr );
            Console.WriteLine( (object)str == (object)thirdStr );
        }
    }
}
