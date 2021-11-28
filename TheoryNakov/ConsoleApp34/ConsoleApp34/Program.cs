using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public class Dog
        {
            //static variables
            public const string SPECIES = "Canis Lupus Familiars";
            //Instance variables
            private int Age;
            //Constructors
            public Dog(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            //Properties
            public string Name { get; set; }
            //Methods
            public void Breath()
            {
                //TODO: breathing process
            }
            public void Bark()
            {
                Console.WriteLine("wow-wow");
            }
        }
    }
}
