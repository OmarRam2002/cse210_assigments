public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void setFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public (int top, int bottom) getFraction()
    {
        return (_top, _bottom);

    }
    public double getDecimalValue()
    {
        return (double)_top / _bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
}