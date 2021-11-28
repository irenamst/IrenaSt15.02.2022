using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static (string FirstName, string LastName, int Age) ParsePersonData (string data)
        {
            string[] parts=data.Split (' ');
            string firstName = parts[0];
            string lastName = parts[1];
            int age = int.Parse (parts[2]);
            return (FirstName: firstName,LastName: lastName,Age: age);
        }
        static void Main(string[] args)
        {
            string personData = "Ivan Ivanov 28";
            var personInfo=ParsePersonData(personData);
            Console.WriteLine(personInfo);
        }
    }
}
