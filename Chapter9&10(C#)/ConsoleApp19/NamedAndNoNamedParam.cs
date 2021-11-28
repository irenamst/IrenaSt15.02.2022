using System;

namespace ConsoleApp19
{
    class NamedAndNoNamedParam
    {
        static void SomeMethod(int x, int y = 5, int z = 7)
        {
            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
        }
        static void Main(string[] args)
        {
            SomeMethod(1, 2, 3);
            SomeMethod(1, 2);
            SomeMethod(1);
        }
    }
}
