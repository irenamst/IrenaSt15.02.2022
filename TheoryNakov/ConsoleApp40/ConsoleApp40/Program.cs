using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string>bulgarianNumbers=new Dictionary<int,string>();
            DateTime date = DateTime.Now.Date;
            int count = 0;
            Student student = new Student();
            
                    
        }
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Employee
        {
            public string firstName;
            public string lastName;
            
        }
        public class Timer
        {
            public void Start() { }
        }
        public class AtomTimer : Timer 
        { 
            new public void Start() { }
        }
        
    }
}
