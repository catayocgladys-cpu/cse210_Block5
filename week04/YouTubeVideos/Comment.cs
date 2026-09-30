//This class stores the name of the person who commented and the text of their comment. 
//Gladys Catayoc

public class Comment
{
    public string Name { get; private set; }
    public string Text { get; private set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}