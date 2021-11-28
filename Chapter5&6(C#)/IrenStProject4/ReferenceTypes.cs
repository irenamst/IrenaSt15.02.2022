using System;

namespace IrenStProject4
{
    class ReferenceTypes
    {
        static void Main(string[] args)
        {
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "bee";
            thirdStr = thirdStr + 'r';
            Console.WriteLine("str = {0} ",str);
            Console.WriteLine("anotherStr = {0} ", anotherStr);
            Console.WriteLine("thirdStr = {0} ", thirdStr);
            Console.WriteLine(str = anotherStr); //True
            Console.WriteLine(str = thirdStr);  //True
            Console.WriteLine((object)str == (object)anotherStr); //False
            Console.WriteLine((object)str == (object)thirdStr); //True

        }
    }
}
