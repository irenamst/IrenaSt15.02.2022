using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 3;
            if(first ==second){
                Console.WriteLine("first == second");
            }
            else {
                if (first > second)
                {
                    Console.WriteLine("first > second");
                }
                else {
                    Console.WriteLine("first < second");
                }
            }
        }
    }
}
