//This runs the program
//Gladys Catayoc
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity feature:
        // I added a progress message that shows how many
        // words are still visible after each round.
        // This helps the user track their progress.

        Reference reference = new Reference("D&C", 20, 37);

        string text = "And again, by way of commandment to the church concerning the manner of baptism—All those who humble themselves before God, and desire to be baptized, and come forth with broken hearts and contrite spirits, and witness before the church that they have truly repented of all their sins, and are willing to take upon them the name of Jesus Christ, having a determination to serve him to the end, and truly manifest by their works that they have received of the Spirit of Christ unto the remission of their sins, shall be received by baptism into his church.";

        Scripture scripture = new Scripture(reference, text);

        // Keep going until all the words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            // Show progress
            Console.WriteLine(
                $"Words remaining: {scripture.GetVisibleWordCount()}");

            Console.WriteLine();

            // Ask the user what they want to do
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            // Exit if the user types quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words
            scripture.HideRandomWords();
        }

        // Show the final scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Great job! You finished memorizing the scripture.");
        }
        else
        {
            Console.WriteLine("Good job! Keep practicing the scripture.");
        }
    }
}