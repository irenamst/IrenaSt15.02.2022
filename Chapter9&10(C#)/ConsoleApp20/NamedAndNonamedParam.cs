using System;

namespace ConsoleApp20
{
    class NamedAndNonamedParam
    {
        static void SomeMethod(int x, int y = 5, int z = 7)
        {
            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);
        }
        static void Main(string[] args)
        {
            SomeMethod(1, z: 3);
            SomeMethod(x: 1, z: 3);
            SomeMethod(z: 3, x: 1);
        }
    }
}
