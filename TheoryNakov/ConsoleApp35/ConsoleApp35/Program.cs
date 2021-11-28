using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulgarianNumbers = new Dictionary<int,string>();
            var students = new Dictionary<int, string>();
            bulgarianNumbers.Add(1, "едно");
            bulgarianNumbers.Add(2, "две");
            students.Add(1, "IrenaStaneva");
            students.Add(2, "NadyaBorisova");
            foreach(var pair in bulgarianNumbers)
            {
                Console.WriteLine($"Pair:[{ pair.Key },{ pair.Value}]");
            }
            foreach(var student in students)
            {
                Console.WriteLine($"Student:[{student.Key},{student.Value}]");
            }
        }
    }
}
