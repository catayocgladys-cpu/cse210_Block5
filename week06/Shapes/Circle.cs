//Circle class

//inherits from Shape parent class
public class Circle : Shape
{
    //store the radius
    private double _radius;

    //set the radius in the constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    //calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}