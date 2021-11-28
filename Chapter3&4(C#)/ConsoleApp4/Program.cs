using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the company: ");
            string nameOfCompany = Console.ReadLine();
            Console.WriteLine("Enter the address of the company: ");
            string addressOfCompany = Console.ReadLine();
            Console.WriteLine("Enter the telephone number of the company: ");
            string telephoneOfTheCompany = Console.ReadLine();
            Console.WriteLine("Enter the fax of the company: ");
            string faxOfCompany = Console.ReadLine();
            Console.WriteLine("Enter the website of the company: ");
            string websiteOfCompany = Console.ReadLine();
            Console.WriteLine("Enter the first name of the manager: ");
            string firstNameOfManager = Console.ReadLine();
            Console.WriteLine("Enter the last name of the manager:");
            string lastNameOfManager = Console.ReadLine();
            Console.WriteLine("Enter the telephone number of the manager: ");
            string telephoneOfManager = Console.ReadLine();
            Console.WriteLine("Company: "+nameOfCompany+", " );
            Console.WriteLine("Address: "+ addressOfCompany + ", ");
            Console.WriteLine("Telephone: " + telephoneOfTheCompany + ", ");
            Console.WriteLine("Fax: " + faxOfCompany + ", ");
            Console.WriteLine("Website: "+websiteOfCompany);
            Console.WriteLine("Manager name: " + firstNameOfManager + " " + lastNameOfManager);
            Console.WriteLine("telophone of the manager: " + telephoneOfManager);
        }
    }
}
