using System;

namespace IrenaProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("char 'a'=='a'?"+('a'=='a'));//True
            Console.WriteLine("char 'a'=='b'?" + ('a' == 'b'));//False
            Console.WriteLine("'a'!='b'? " + ('a' != 'b'));//True
            Console.WriteLine("5!=6? " + (5 != 6));//True
            Console.WriteLine("5.0==5L? " + (5.0 != 5L));//False
            Console.WriteLine("true==false? " + (true == false));//False
        }
    }
}
