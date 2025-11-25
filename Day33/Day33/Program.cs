using System;
using System.Collections;

namespace HashtableCollection
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Hashtable employeeDetails = new Hashtable();
            employeeDetails.Add("Id", 1000);
            employeeDetails.Add("FirstName", "John");
            employeeDetails.Add("LastName", "Doe");
            employeeDetails.Add("Age", 35);
            employeeDetails.Add("EmailAddress", "john@company.com");

            // Adding elements using the indexer
            employeeDetails["Salary"] = 30000;
            employeeDetails["Gender"] = "Male";

            // Updating values using indexer
            employeeDetails["FirstName"] = "Jack"; // Updates from John to Jack
            employeeDetails["LastName"] = "Smith"; // Updates from Doe to Smith

            // Adding elements using collection initializer syntax
            Hashtable employee = new Hashtable()
            {
                {"Id", 1000},
                {"FirstName", "John"},
                {"LastName", "Doe"},
                {"Age", 35},
                {"EmailAddress", "john@company.com"}
            };

            Console.WriteLine(employeeDetails["FirstName"]);
            Console.WriteLine(employeeDetails["LastName"]);

            if (employeeDetails.ContainsKey("Age"))
            {
                employeeDetails.Remove("Age");
            }

            foreach(DictionaryEntry entry in employeeDetails)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

            // Checking for existence of keys
            Console.WriteLine(employeeDetails.Contains("Id"));// True
            Console.WriteLine(employeeDetails.Contains("Location")); // False

            // Checking for existence of values
            Console.WriteLine(employeeDetails.ContainsValue("John")); // True
            Console.WriteLine(employeeDetails.ContainsValue("Sales and Marketing")); // False
        }
    }
}
