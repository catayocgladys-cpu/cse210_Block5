// This is Exercise 5 from Week 1 of the C# Programming course
// FUNCTIONS
// Gladys Catayoc


using System;

class Program
{
    // This function displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // This function asks the user for their name
    // It returns the name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // This function asks the user for their favorite number
    // It returns the number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // This function takes a number and squares it
    // It returns the squared number
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    // This function displays the user's name and squared number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    // The Main function starts the program
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Call the name function and save the returned name
        string name = PromptUserName();

        // Call the number function and save the returned number
        int number = PromptUserNumber();

        // Send the number to the SquareNumber function
        // Save the returned squared number
        int square = SquareNumber(number);

        // Send the name and square to the DisplayResult function
        DisplayResult(name, square);
    }
}