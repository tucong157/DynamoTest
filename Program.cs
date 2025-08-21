using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            // Use LINQ to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 1);
            // Print the even numbers
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}
