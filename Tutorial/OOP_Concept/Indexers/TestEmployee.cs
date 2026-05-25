using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Indexers
{
    internal class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "John Doe", "Software Engineer", "IT", "New York", 75000.00);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("ID: " + emp["id"]);
            Console.WriteLine("Name: " + emp["name"]);
            Console.WriteLine("Job Title: " + emp["jobTitle"]);
            Console.WriteLine("Department: " + emp["dept"]);
            Console.WriteLine("Location: " + emp["location"]);
            Console.WriteLine("Salary: $" + emp["salary"]);
            // Update employee details using indexer
            emp["name"] = "Jane Smith";
            emp["salary"] = 80000.00;
            Console.WriteLine("\nUpdated Employee Details:");
            Console.WriteLine("ID: " + emp["id"]);
            Console.WriteLine("Name: " + emp["name"]);
            Console.WriteLine("Job Title: " + emp["jobTitle"]);
            Console.WriteLine("Department: " + emp["dept"]);
            Console.WriteLine("Location: " + emp["location"]);
            Console.WriteLine("Salary: $" + emp["salary"]);
        }
    }
}
  