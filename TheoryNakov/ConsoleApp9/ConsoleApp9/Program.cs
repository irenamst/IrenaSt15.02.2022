using System;
using System.Collections.Generic;
using System.Linq;//Very important!
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog{Name="Rex",Age=4},
                new Dog{Name="Sharo",Age=0},
                new Dog{Name="Stasi",Age=3}
            };
            //Import the namespace "Sysytem.Linq" to use .Select;
            var names=dogs.Select(x=> x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
