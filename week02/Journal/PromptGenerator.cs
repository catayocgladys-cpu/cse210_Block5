//This class keeps a list of questions and chooses a random question for the user. 
//This is week 2 on Journal. In this assignment, you will create a PromptGenerator class that keeps a list of questions and chooses a random question for the user. You will then create a PromptGenerator object, call its method to get a random question, and display the question.
//Gladys Catayoc


using System;
using System.Collections.Generic;

// This class creates and provides journal prompts.
public class PromptGenerator
{
    // This is a list of questions that the program can use.
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What is one thing I am grateful for today?"
    };

    // This method chooses a random prompt from the list.
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}

