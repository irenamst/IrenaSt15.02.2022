using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class RandomPasswordGenerator
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChar = "~!@#$%^&*()_-+=`{}[]\\|'.,:;?><";
        private const string AllChar = CapitalLetters + SmallLetters + Digits + SpecialChar;
        static private Random rnd = new Random();
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }

            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChar);
                InsertAtRandomPosition(password, specialChar);
            }

            int count = rnd.Next(8);
            for (int i = 1; i <= count; i++)
            {
                char specialChar = GenerateChar(AllChar);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password.ToString());
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int RandomPosition = rnd.Next(password.Length + 1);
            password.Insert(RandomPosition, character);
        }
        private static char GenerateChar(string availableCharacters)
        {
            int randomIndex = rnd.Next(availableCharacters.Length);
            char randomChar = availableCharacters[randomIndex];
            return randomChar;
        }
    }
}
