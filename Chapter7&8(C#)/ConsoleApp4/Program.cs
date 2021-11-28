using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"one","two","three","four"};
            for(int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("Element[{0}]={1}",index,array[index]);
            }
        }
    }
}
