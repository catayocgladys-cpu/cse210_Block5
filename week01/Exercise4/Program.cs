// This is Exercise 4 from Week 1 of the C# Programming course
// LISTS AND GENERICS
// Gladys Catayoc

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store decimal numbers
        List<float> numbers = new List<float>();

        // Tell the user what to do
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Start the number with -1 so the loop can begin
        float number = -1;

        // Keep asking for numbers until the user enters 0
        while (number != 0)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());

            // Add the number to the list if it is not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Create a variable to keep track of the sum
        float sum = 0;

        // Assume the first number is the largest
        float largest = numbers[0];

        // Start with the first number for the smallest positive number
        float smallestPositive = numbers[0];

        // Go through each number in the list
        foreach (float n in numbers)
        {
            // Add each number to the sum
            sum = sum + n;

            // Check if the number is larger than the current largest
            if (n > largest)
            {
                largest = n;
            }

            // Check if the number is positive
            if (n > 0)
            {
                // Check if it is the smallest positive number
                if (smallestPositive <= 0 || n < smallestPositive)
                {
                    smallestPositive = n;
                }
            }
        }

        // Calculate the average
        float average = sum / numbers.Count;

        // Display the sum
        Console.WriteLine($"The sum is: {sum}");

        // Display the average
        Console.WriteLine($"The average is: {average:F2}");

        // Display the largest number
        Console.WriteLine($"The largest number is: {largest}");

        // Display the smallest positive number
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the numbers from smallest to largest
        numbers.Sort();

        // Display the sorted list
        Console.WriteLine("The sorted list is:");

        foreach (float n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
