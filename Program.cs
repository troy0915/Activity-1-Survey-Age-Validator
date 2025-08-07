using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1_Survey_Age_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            int teenagerCount = 0;

            Console.WriteLine("Please enter the ages of 5 customers (between 10 and 99):");
            for (int i = 0; i < ages.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Customer {i + 1} age: ");
                    if (int.TryParse(Console.ReadLine(), out int age) && age >= 10 && age <= 99)
                    {
                        ages[i] = age; // Store valid age in the array
                        if (age >= 13 && age <= 19)
                        {
                            teenagerCount++; // Count if the age is a teenager
                        }
                        break; // Exit the loop for valid input
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a value between 10 and 99.");
                    }
                }
            }
            Console.WriteLine("\nValid Ages:");
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine($"Customer {i + 1}: {ages[i]}");
            }

            Console.WriteLine($"\nTotal number of teenagers (ages 13-19): {teenagerCount}");
        }
    }
}




