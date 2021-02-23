using System;
using System.Collections.Generic;
using System.Linq;

namespace Week4Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayNamesQuery();
        }

        private static void DisplayNamesQuery()
        {
            string[] names = { "Mary", "Joseph", "Sarah", "Margaret", "John" };

            var outputNames = names.OrderBy(n => n).Where(n => n.StartsWith("M")); //orders alphabetically ".Select" = just displays them 

            foreach (string name in outputNames)
            {
                Console.WriteLine(name);
            }

            

            var cust = GetCustomers().ToList();
            var cust1 = cust.Where(n => n.City == "Dublin" || n.City == "Galway")
                .Select(n => new{Name = n.Name, City = n.City})
                .OrderBy(n => n.Name);
            foreach (var s in cust1)
            {
                Console.WriteLine(s.Name);
            }

            
            Console.ReadLine();

        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }
    }
    public class Customer
    {
        public string Name;
        public string City;
    }
}
