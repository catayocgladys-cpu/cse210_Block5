//This runs the program
//Gladys Catayoc
using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements / Creativity:
        // Added a progress indicator that tracks and reports the exact count 
        // of remaining visible words after every iteration, giving the user 
        // clear visibility into their memorization progress.

        // 1. Create the scripture reference
        Reference reference = new Reference("D&C", 20, 37);

        // 2. Store the scripture text
        string text = "And again, by way of commandment to the church concerning the manner of baptism—All those who humble themselves before God, and desire to be baptized, and come forth with broken hearts and contrite spirits, and witness before the church that they have truly repented of all their sins, and are willing to take upon them the name of Jesus Christ, having a determination to serve him to the end, and truly manifest by their works that they have received of the Spirit of Christ unto the remission of their sins, shall be received by baptism into his church.";

        // 3. Create the Scripture object
        Scripture scripture = new Scripture(reference, text);

        // Track user input outside the loop
        string input = "";

        // 4. Main interaction loop: continue until words are all hidden or user types 'quit'
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display current scripture state
            Console.WriteLine(scripture.GetDisplayText());

            // Display remaining word count
            Console.WriteLine();
            Console.WriteLine($"Words remaining: {scripture.GetVisibleWordCount()}");

            // Prompt user
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine() ?? "";

            // Check if user requests exit
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide words for the next turn
            scripture.HideRandomWords();
        }
        // 5. Final screen: display only if the user finished (did not type 'quit')
        if (input.Trim().ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Words remaining: {scripture.GetVisibleWordCount()}");
            Console.WriteLine();
            Console.WriteLine("Great job! All words have been hidden.");
        }
    }
}