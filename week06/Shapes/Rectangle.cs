//Second child class

//this is the inheritance
public class Rectangle : Shape
{
    //store two measurements
    private double _length;
    private double _width;

    //the constructor, receives the color, length, and width. the base(color) sends the color to the parent class 
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Calculate the area
    public override double GetArea()
    {
        return _length * _width;
    }
}
    

