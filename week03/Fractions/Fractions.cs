//This is the Fraction.cs in this project. It is used to demonstrate encapsulation in C#.
//Week 3 Encapsulation Learning Activity
//Gladys Catayoc

public class Fraction
{
    //These are private attributes. 
    //Stores the top and bottom of the fraction.
    private int _top;
    private int _bottom;

    //Constructor 1
    //This creates a fraction of 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor 2
    //This receives only the top number.
    //The bottom number will automatically be 1.
    //Example: 3 will be 3/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //Constructor 3
    //This receives both the top and bottom numbers.
    //Example: Fraction(3, 4) will be 3/4
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getter for the top number
    //It allows other parts of the program to see the top number.
    public int GetTop()
    {
        return _top;
    }

    //Setter fpr the top number
    //It allows us to change the top number.
    public void SetTop(int top)
    {
        _top = top;
    }

    //Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }
     // Setter for the bottom number.
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // This method returns the fraction as a string.
    // Example: 3/4
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // This method changes the fraction into a decimal.
    // Example: 3/4 becomes 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}