using System;

namespace ConsoleApp23
{
    class TwoDeclaration
    {
        static void DoSomething(int param1, float param2)
        {

        }
        static void DoSomething(float param1, int param2)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
