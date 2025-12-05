public class Cirle: Shapes
{
    private int _radius;

    public Cirle(string color, int radius): base(color)
    {
        _radius = radius;

    }

    public override double GetArea()
    {
        return (_radius * _radius)  * Math.PI;
    }

}