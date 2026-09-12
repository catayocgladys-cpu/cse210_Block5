using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name and last name. Then display their full name in the format: "Your name is [last name], [first name] [last name]."
        Console.Write("What is your first name?");
        string first =Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}