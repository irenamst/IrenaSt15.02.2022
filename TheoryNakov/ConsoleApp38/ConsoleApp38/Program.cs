using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer>();

            for (int i= 0; i < customer.Count; i++){

            }
        }
        public class Account
        {
            public string Name { get; set; }
        }
        protected Account[] customersAccounts;
        public class Customer
        {
            protected Account[] customersAccounts;
        }
        
    }
}
