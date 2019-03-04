using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Shopping_Spree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();


            var inputPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);


            foreach (var personDetails in inputPeople)
            {
                var splittedPersonDetails = personDetails.Split("=");
                var name = splittedPersonDetails[0];
                var money = int.Parse(splittedPersonDetails[1]);


                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            var inputProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productDetails in inputProducts)
            {
                var splittedProductDetails = productDetails.Split("=");
                var productName = splittedProductDetails[0];
                var cost = int.Parse(splittedProductDetails[1]);


                try
                {
                    Product product = new Product(productName, cost);
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var input = Console.ReadLine();

            while (input != "END")
            {
                var splittedInput = input.Split(" ");
                var personName = splittedInput[0];
                var productName = splittedInput[1];

                Person currentPerson = people.Where(p => p.Name == personName).First();
                Product currentProduct = products.Where(p => p.Name == productName)?.First();
                bool hasEnought = currentPerson.Buy(currentProduct);
                if (hasEnought)
                {
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }

                input = Console.ReadLine();

            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {(person.Products.Count() > 0 ? string.Join(", ", person.Products.Select(p => p.Name)) : "Nothing bought")}");
            }

        }
    }
}
