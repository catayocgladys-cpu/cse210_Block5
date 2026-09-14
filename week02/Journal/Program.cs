//This Program.cs is where the program starts. It creates a Journal object, adds Entry objects to it, and displays the entries.
//This is week 2 on Journal. In this assignment, you will create a Journal class that manages all of the user's journal entries. The Journal class will have a list of Entry objects and methods to add, display, save, and load entries. You will then create a Journal object, add Entry objects to it, and display the entries.
//Gladys Catayoc

// CREATIVITY / EXCEEDING REQUIREMENTS:

//I added extra journal prompts to give the user more choices.
//I also added a simple message when an entry is successfully added, saved, or loaded. These additions make the journal easier and more enjoyable to use while keeping the program simple for a beginner.


using System;

// This is the main class where the program starts.
class Program
{
    static void Main(string[] args)
    {
        // Create a Journal object.
        Journal theJournal = new Journal();

        // Create a PromptGenerator object.
        PromptGenerator prompts = new PromptGenerator();

        // This variable controls when the program stops.
        bool running = true;

        // Keep showing the menu while the program is running.
        while (running)
        {
            // Display the menu.
            Console.WriteLine();
            Console.WriteLine("Journal Program");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");

            // Get the user's choice.
            string choice = Console.ReadLine();

            Console.WriteLine();

            // Decide what to do based on the user's choice.
            if (choice == "1")
            {
                // Get a random prompt.
                string prompt = prompts.GetRandomPrompt();

                // Show the prompt.
                Console.WriteLine(prompt);

                // Get the user's response.
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                // Get today's date.
                string date = DateTime.Now.ToString("MMMM dd, yyyy");

                // Create a new Entry.
                Entry newEntry = new Entry();

                // Store the information in the entry.
                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._response = response;

                // Add the entry to the journal.
                theJournal.AddEntry(newEntry);

                Console.WriteLine();
                Console.WriteLine("Your entry has been added!");
            }
            else if (choice == "2")
            {
                // Display all journal entries.
                theJournal.Display();
            }
            else if (choice == "3")
            {
                // Ask the user for a filename.
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                // Save the journal.
                theJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                // Ask the user for a filename.
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                // Load the journal.
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                // Stop the program.
                running = false;

                Console.WriteLine("Thank you for using the Journal Program!");
            }
            else
            {
                // Tell the user if they entered an invalid choice.
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}


