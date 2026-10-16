using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public void FractionOne()
    {
        _top = 1;
        _bottom = 1;
    }

    public void FractionTwo(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public void FractionThree(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_top/_bottom;
    }
}