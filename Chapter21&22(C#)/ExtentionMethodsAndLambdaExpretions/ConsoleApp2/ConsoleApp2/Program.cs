using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static (string FirstName, string LastName, int Age) personInfo = ("Ivan", "Ivanov", 28);
        static (string FirstName, string LastName, int Age) ParsePersonData(string data)
        {
            string[] parts = data.Split(' ');
            string firstName = parts[0];
            string lastName = parts[1];
            int age = int.Parse(parts[2]);
            return (FirstName: firstName, LastName: lastName, Age: age);
        }
        static void Main(string[] args)
    {
        var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };
        Console.WriteLine($"My car is a {myCar.Color}, {myCar.Brand}.");
        Console.WriteLine($"It runs{myCar.Speed} km/h");
        Console.WriteLine($"ToString:{myCar.ToString()}");
        Console.WriteLine($"Hash cade: {myCar.GetHashCode().ToString()}");
        Console.WriteLine("Equals? {0}", myCar.Equals(new { Color = "Red", Brand = "BMW", Speed = 180 }));
        Console.WriteLine("Type name: {0}", myCar.GetType().ToString());

        var elements = new[] { new { X = 3, Y = 5 }, new { X = 1, Y = 2 }, new { X = 0, Y = 7 } };

        string personData = "Ivan Ivanov 28";
        var personInfo= ParsePersonData(personData);

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> evenNumbers = numbers.FindAll(x => (x % 2 == 0));
            foreach (var num in evenNumbers)
                {
                    Console.WriteLine($"{num}");

                }
        Console.WriteLine();

        //class Dog
        List<Dog> dogs = new List<Dog>() {
            new Dog{Name="Rex",Age=4 },
            new Dog{Name="Share", Age=0 },
            new Dog{Name="Stasi",Age = 3 }
        };

        var names=dogs.Select(x => x.Name);
            foreach(var name in names)
                {
                    Console.WriteLine(name);
                }

        var newDogsList = dogs.Select(x => new {Age=x.Age, FirstLetter=x.Name[0] });

            foreach(var item in newDogsList)
            {
                Console.WriteLine(item);
            }
            
            List<int> numbers1=new List<int>() {20,1,4,8,9,44 };
            var evenNumbers1 = numbers1.FindAll((i) =>
            {
                Console.WriteLine("Value of i is: {0}", i);
                return (i % 2 == 0);
            });

            var sortedDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine($"Dog{dog.Name} is {dog.Age} years old.");
            }

            Func<bool> boolFunc=() => true;
            Func<int,bool> intFunc = (x) => x < 10;
            if(boolFunc() && intFunc(5))
            {
                Console.WriteLine("5<10");
            }
        }
    }
}
