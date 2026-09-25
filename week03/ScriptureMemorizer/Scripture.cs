//Manages the scripture and its words
// Gladys Catayoc

using System;
using System.Collections.Generic;
public class Scripture
{
    //The scripture reference 
    private Reference _reference;

    //A list stores all the Word objects.
    private List<Word> _words;

    //Used to choose random words
    private Random _random;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random(); 

        //Split the scripture into individual words
        string[] wordList = text.Split(' ');

        //Create a word object for each word.
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    // Formats and returns the reference and scripture text
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.TrimEnd();
    }

    // Hides a randomly selected work that is not already hidden.
    public void HideRandomWord()
    {
        // Gather all words that haven't been hidden yet
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Hide one word from the visible pool if any remain
        if (visibleWords.Count > 0)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
    //Checks if every word in the scripture has been hidden.  
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}