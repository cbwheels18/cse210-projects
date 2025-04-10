public class RectangleShape : Shape
{
    private double _width;
    private double _length;

    public RectangleShape(double width, double length, string color) : base (color)
    {
        _width = width;
        _length = length;
    }

    public override double Area()
    {
        return _width * _length;
    }
}