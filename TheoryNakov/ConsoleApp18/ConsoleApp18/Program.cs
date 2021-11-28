using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Product
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ Name = "Strawberry", CategoryID=1},
                new Product(){Name="Banana",CategoryID=1},
                new Product(){Name="Chicken meat",CategoryID=2},
                new Product(){Name="Apple Juice",CategoryID=4},
                new Product(){Name="Fish",CategoryID=2},
                new Product(){Name="Orange Juice",CategoryID=4},
                new Product(){Name="Sandal",CategoryID =3}
            };
            List<Category> categories = new List<Category>()
            {
                new Category(){ID=1,Name="Fruit"},
                new Category(){ID=2,Name="Food"},
                new Category(){ID=3,Name="Shoe"},
                new Category(){ID=4,Name="Juice"}
            };
            var productsWithCategories =
                from product in products
                join category in categories
                on product.CategoryID equals category.ID
                select new { Name = product.Name, Category = category.Name };
            foreach(var item in productsWithCategories)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var productsWithCategories2 =
                from product in products
                select new
                {
                    Name = product.Name,
                    Category =
                        (from category in categories
                        where category.ID == product.CategoryID
                        select category.Name)
                        .First()
                };
            foreach(var item in productsWithCategories2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
