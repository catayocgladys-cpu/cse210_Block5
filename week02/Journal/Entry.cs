//This Entry class represents a journal entry. It contains the date, prompt, and response for the entry.
//This is week 2 on Journal. In this assignment, you will create an Entry class that represents a journal entry. The Entry class will have properties for the date, prompt, and response. You will then create an Entry object, set its properties, and display the entry.
//Gladys Catayoc


using System;

// This class represents one journal entry.
public class Entry
{
    // These variables store information about the entry.
    public string _date;
    public string _prompt;
    public string _response;

    // This method displays the journal entry.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}

