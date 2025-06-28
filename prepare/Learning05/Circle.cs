// Circle Child Class (Parent:Shape)
public class Circle : Shape
{
    // the important value for area for circles is the radius so we need to make sure that we define that
    private double _radius;

    // our constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Makeing sure to overide the default (don't want a zero)
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}