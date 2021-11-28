using System;

namespace ConsoleApp12
{
    class ReadKeyProgram
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Characters entered: "+Key.KeyChar);
            Console.WriteLine("Special keys: "+Key.Modifiers);

        }
    }
}
