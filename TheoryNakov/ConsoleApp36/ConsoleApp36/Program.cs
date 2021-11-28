using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulgarianNumbers=new Dictionary<int, string>();
            bulgarianNumbers.Add(1, "едно");
            bulgarianNumbers.Add(2, "две");
            foreach(var pair in bulgarianNumbers.ToArray())
            {
                Console.WriteLine($"Pair:[{pair.Key},{pair.Value}]");
            }
            
            
           
        }
        class Student
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public Student(int age,string name)
            {
                this.Age = age;
                this.Name = name;
            }

        }
    }
}
