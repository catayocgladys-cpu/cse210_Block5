//This is Exercise 3 from Week 1 of the C# Programming course
// GUESS MY NUMBER GAME
//Gladys Catayoc

using System;

class Program
{
    static void Main(string[] args)
    {
        // Guess My Number game the computer picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.
       string playAgain = "yes";

        while (playAgain == "yes")
        {
            //Ask user to give the range of the magic number
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Guess the magic number!");

            //Ask the user to guess the magic number until they get it right
            // this is the loop that will keep asking the user for their guess until they guess the magic number

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"You made {guessCount} guesses.");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}