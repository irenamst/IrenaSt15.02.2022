using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(99999, "Vlady", 13);
            Console.WriteLine(student.Id+" "+student.Name+" "+student.Age);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Student(int id,string name,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
