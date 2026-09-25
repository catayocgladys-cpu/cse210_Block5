//Manages the scripture and its words
// Gladys Catayoc

using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the scripture into individual words
        string[] wordList = text.Split(' ');

        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    // Displays the reference and all the words
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        displayText += " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText();
            displayText += " ";
        }

        return displayText.Trim();
    }

    // Hides 3 random words
    public void HideRandomWords()
    {
        int wordsToHide = 3;
        int hiddenThisRound = 0;

        while (hiddenThisRound < wordsToHide && !IsCompletelyHidden())
        {
            int randomIndex = _random.Next(_words.Count);

            Word word = _words[randomIndex];

            // Only hide the word if it is not already hidden
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenThisRound++;
            }
        }
    }

    // Checks if every word is hidden
    public bool IsCompletelyHidden()
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

    // Counts how many words are still visible
    public int GetVisibleWordCount()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }
}