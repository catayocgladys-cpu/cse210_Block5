// Scripture Memorizer
// Gladys Catayoc


class Program
{
    static void Main(string[] args)
    {
        // Creativity feature:
        // I added a progress message to show how many
        // words are still visible.

        Reference reference = new Reference("D&C", 20, 37);

        string text = "And again, by way of commandment to the church concerning the manner of baptism—All those who humble themselves before God, and desire to be baptized, and come forth with broken hearts and contrite spirits, and witness before the church that they have truly repented of all their sins, and are willing to take upon them the name of Jesus Christ, having a determination to serve him to the end, and truly manifest by their works that they have received of the Spirit of Christ unto the remission of their sins, shall be received by baptism into his church.";

        Scripture scripture = new Scripture(reference, text);

        // Keep showing the scripture until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Words remaining: " + scripture.GetVisibleWordCount());
            Console.WriteLine();

            Console.WriteLine("Press ENTER to hide 3 words.");
            Console.WriteLine("Press Q to quit.");

            // Wait for the user to press a key
            ConsoleKeyInfo key = Console.ReadKey(true);

            // Quit if Q is pressed
            if (key.Key == ConsoleKey.Q)
            {
                break;
            }

            // Hide 3 words only when ENTER is pressed
            if (key.Key == ConsoleKey.Enter)
            {
                scripture.HideRandomWords();
            }
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
            Console.WriteLine("Keep practicing the scripture!");
        }
    }
}
