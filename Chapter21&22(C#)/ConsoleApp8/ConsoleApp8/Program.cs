using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Student
    {
        int age { get; set; }
        string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            foreach(Student s in student)
            {
                Console.WriteLine(s.name);
                Console.WriteLine(s.age);
            }
        }
    }
}
