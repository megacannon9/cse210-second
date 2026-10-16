using System.Diagnostics.Contracts;
using System.Formats.Asn1;

class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        double area;
        area = _radius * _radius * 3.141592653;
        return area;
    }

    public double GetCircumference()
    {
        
        return 2 * 3.14159265 * _radius;
    }

    public void SetRadius(double radius)
    {
        if (_radius < 0.0)
        {
            _radius = 1.0;
            Console.WriteLine("Error, Radius cannot be less than 0");
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetRadius()
    {
        return _radius;
    }
}