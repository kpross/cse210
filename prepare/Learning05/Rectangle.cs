// Rectangle Child Class (Parent Class:Shape)
public class Rectangle : Shape
{
    private double _sideOne;
    private double _sideTwo;

    public Rectangle(string color, double sideOne, double sideTwo) : base(color)
    {
        _sideOne = sideOne;
        _sideTwo = sideTwo;
    }

    public override double GetArea()
    {
        return _sideOne * _sideTwo;
    }
}