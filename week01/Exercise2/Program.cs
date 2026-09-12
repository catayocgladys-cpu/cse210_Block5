using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        string sign;

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // A grades cannot have a plus
        if (letter == "A")
        {
            sign = "-";
        }

        // F grades cannot have a plus or minus
        if (letter == "F")
        {
            sign = "";
        }

        // Display the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the student passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do better next time!");
        }
    }
}