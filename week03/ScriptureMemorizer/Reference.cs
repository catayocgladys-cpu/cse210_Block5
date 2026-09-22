//This is the class responsible for the scripture reference. It will store the book, chapter, and verse of the scripture. D&C 20:37
public class Reference
{
    //These variable store the scripture reference information. 

    private string _book;
    private int _chapter;
    private int _verse;

    //Constructor for one verse.
    //Example: D&C 20:37
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //Constructor for a range of verses.
    //Example: Proverbs 3:5-6
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verseStart;
        //We will store the end verse in the _verse variable as well.
        //This is a simplification for this project.
        //In a real application, we would likely have a separate variable for the end verse.
        _verse = verseEnd;
    }

    // This method returns the reference as text
    public string GetDisplayText()
    {
        if(_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
       
    }

}