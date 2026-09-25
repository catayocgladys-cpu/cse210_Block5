//The Word class represents one word in the scripture. It can be hidden or visible.
 // Gladys Catayoc

 using System;
 using System.Text;
 public class Word
{
    //Stores the original word
    private string _text;
    //Tracks visibility state
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Marks the word as hidden
    public void Hide()
    {
        _isHidden = true;
    }

    //Reveals the word (standard for this design pattern)
    public void Show()
    {
        _isHidden = false;
    }

    //Checks whether the word is currently hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    //Returns the original word if visible, or underscores if hidden
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        StringBuilder hiddenWord = new StringBuilder();

        foreach (char letter in _text)
        {
            if (char.IsLetterOrDigit(letter))
            {
                hiddenWord.Append('_');
            }
            else
            {
                //Preserve punctuation and spaces
                hiddenWord.Append(letter);
            }
        }

        return hiddenWord.ToString();
    }
}
