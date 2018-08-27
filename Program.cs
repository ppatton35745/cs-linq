using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // // **************************** //
            // // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // List<string> LFruits = (from fruit in fruits
            //                         where fruit[0] == 'L'
            //                         orderby fruit ascending
            //                         select fruit).ToList();

            // DisplaySet(LFruits);
            // // **************************** //



            // // **************************** //

            // // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // List<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();

            // DisplaySet(fourSixMultiples);

            // // **************************** //



            // // **************************** //
            // // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // List<string> descend = names.OrderByDescending(name => name).ToList();

            // DisplaySet(descend);
            // // **************************** //



            // // **************************** //
            // // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();

            // DisplaySet(sortedNumbers);
            // // **************************** //



            // // **************************** //
            // // Output how many numbers are in this list
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // Console.WriteLine(numbers.Count());
            // // **************************** //



            // // **************************** //
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // Console.WriteLine(purchases.Sum().ToString("C"));
            // // **************************** //



            // // **************************** //
            // // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // Console.WriteLine(prices.Max().ToString("C"));
            // // **************************** //



            // // **************************** //
            // /*
            // Store each number in the following List until a perfect square
            // is detected.

            // Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            // */
            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // List<int> nonSquares = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0).ToList();
            // foreach (var item in nonSquares)
            // {
            //     Console.WriteLine(item.ToString());
            // }
            // // **************************** //



            // **************************** //
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=803666645.66, Bank="FTB", Location="E"},
                new Customer(){ Name="Joe Landy", Balance=928466756.21, Bank="WF", Location="W"},
                new Customer(){ Name="Meg Ford", Balance=48723663.01, Bank="BOA", Location="E"},
                new Customer(){ Name="Peg Vale", Balance=700166449.92, Bank="BOA", Location="W"},
                new Customer(){ Name="Mike Johnson", Balance=666666666.12, Bank="WF", Location="E"},
                new Customer(){ Name="Les Paul", Balance=83764892.54, Bank="WF", Location="W"},
                new Customer(){ Name="Sid Crosby", Balance=9567436.39, Bank="FTB", Location="W"},
                new Customer(){ Name="Sarah Ng", Balance=565662389.85, Bank="FTB", Location="E"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI", Location="E"},
                new Customer(){ Name="Sid Brown", Balance=4956682.68, Bank="CITI", Location="W"}
            };

            List<CustomerGroup> richCustomers =
                (from customer in customers
                 where customer.Balance >= 1000000
                 group customer by new { Bank = customer.Bank, Location = customer.Location } into grp
                 select new CustomerGroup() { Bank = grp.Key.Bank, Location = grp.Key.Location, Customers = grp.ToList() }).ToList();

            foreach (CustomerGroup g in richCustomers)
            {
                Console.WriteLine($"Bank {g.Bank} {g.Location} has:");
                foreach (Customer customer in g.Customers)
                {
                    Console.WriteLine("Name " + customer.Name);
                }
            }
            // **************************** //



            // **************************** //
            // **************************** //



            // **************************** //
            // **************************** //


        }

        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }

            public string Location { get; set; }
        }

        public class CustomerGroup
        {
            public string Bank { get; set; }

            public string Location { get; set; }

            public List<Customer> Customers { get; set; }
        }

        static void DisplaySet(List<string> set)
        {
            foreach (string record in set)
            {
                Console.WriteLine(record);
            }
        }

        static void DisplaySet(List<int> set)
        {
            foreach (int record in set)
            {
                Console.WriteLine(record);
            }
        }

    }
}
