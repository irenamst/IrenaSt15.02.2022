using System;

namespace IrenaProgram
{
    class PrintLetter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter person's name: ");
            string person = Console.ReadLine();
            Console.Write("Enter book's name: ");
            string book = Console.ReadLine();
            string from = "Author Team";
            Console.WriteLine(" Dear, {0}", person);
            Console.Write("We are pleased to inform "+"you that \"{1}\" is the best Bulgarian book. {2}" + 
                "The authors of the book wish you good luck, {0}!{2}",person,book,Environment.NewLine);
            Console.WriteLine(" Years, ");
            Console.WriteLine("  {0}",from);
        }
    }
}
