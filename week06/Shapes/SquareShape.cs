public class SquareShape : Shape
{
    private double _sideLength;

    public SquareShape(double sideLength, string color) : base (color)
    {
        _sideLength = sideLength;
    }
    

    public override double Area()
    {
        return _sideLength * _sideLength;
    }
}