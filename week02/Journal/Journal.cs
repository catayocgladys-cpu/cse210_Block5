//The journal class manages all of the user's journal entries. It contains a list of Entry objects and methods to add, display, save, and load entries.
//This is week 2 on Journal. In this assignment, you will create a Journal class that manages all of the user's journal entries. The Journal class will have a list of Entry objects and methods to add, display, save, and load entries. You will then create a Journal object, add Entry objects to it, and display the entries.
//Gladys Catayoc

using System;
using System.Collections.Generic;
using System.IO;

// This class manages the journal.
public class Journal
{
    // This list stores all of the journal entries.
    public List<Entry> _entries = new List<Entry>();

    // This method adds a new entry to the journal.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // This method displays all entries in the journal.
    public void Display()
    {
        // Check if there are no entries.
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no journal entries yet.");
            return;
        }

        // Display each entry in the list.
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // This method saves the journal to a file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Go through every entry.
            foreach (Entry entry in _entries)
            {
                // Use | as a separator between the information.
                writer.WriteLine(
                    $"{entry._date}|{entry._prompt}|{entry._response}"
                );
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    // This method loads the journal from a file.
    public void LoadFromFile(string filename)
    {
        // Clear the current entries first.
        _entries.Clear();

        // Read all lines from the file.
        string[] lines = File.ReadAllLines(filename);

        // Go through each line.
        foreach (string line in lines)
        {
            // Separate the information using the | symbol.
            string[] parts = line.Split('|');

            // Make sure there are three pieces of information.
            if (parts.Length >= 3)
            {
                Entry entry = new Entry();

                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                // Add the entry to the journal.
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}
