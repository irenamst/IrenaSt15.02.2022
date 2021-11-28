using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Student s = new Student(11111,"Vlady",20);
            Console.WriteLine(s.Id);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
                
        }
    }
}
