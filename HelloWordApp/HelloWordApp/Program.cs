using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello word");

            var _people = new List<Person>();

            for (int i = 0; i < 2; i++)
            {
                var person = new Person();
                Console.WriteLine("Enter first name");
                person.FirstName = Console.ReadLine();

                Console.WriteLine("Enter last name");
                person.LastName = Console.ReadLine();

                _people.Add(person);
            }

            Console.WriteLine("Listing all people..");
            foreach (var person in _people)
            {
                Console.WriteLine(string.Format("{0} {1}", person.FirstName, person.LastName));
            }
            Console.WriteLine();


            Console.WriteLine("All first names:");
            var allFirstName = _people.Select(x => x.FirstName);
            foreach (var name in allFirstName)
            {
                Console.WriteLine(name);
            }
            

            Console.WriteLine("All first names that begins with \"I\"");
            var allPersonsWithFirstLetterI = _people.Where(x => x.FirstName.ToLower().Substring(0, 1) == "i");
            foreach (var item in allPersonsWithFirstLetterI)
            {
                Console.WriteLine(item.FirstName);
            }

            List<Product> _products = new List<Product>();

            var product1 = new Product { Name = "Coca Cola", Category = "Drink", Price = 15.23 };
            var product2 = new Product { Name = "Juice", Category = "Drink", Price = 10 };
            var product3 = new Product { Name = "Water", Category = "Drink", Price = 8.85 };
            var product4 = new Product { Name = "Hamburger", Category = "Food", Price = 25 };
            var product5 = new Product { Name = "Salat", Category = "Food", Price = 23.23 };

            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
            _products.Add(product4);
            _products.Add(product5);

            var totalPricePerCategory = _products.GroupBy(x => x.Category)
                .Select(y => new {Category= y.Key, TotalPrice= y.Sum(z => z.Price)});

            Console.WriteLine("Sum of all products per category");
            foreach (var item in totalPricePerCategory)
            {
                Console.WriteLine(string.Format("Category: {0} - Price {1}", item.Category, item.TotalPrice));
            }

            Console.ReadKey();
        }
    }
}
