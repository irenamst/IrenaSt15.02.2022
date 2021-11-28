using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        enum Color
        {
            Black, Red, Green, Blue, Yellow, Orange, Pink, Gray, White
        }
        class Account
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }
        class NewClass
        {
            protected Account[] customersAccount;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < customers.Length; i++) { … }
        }
    }
}
