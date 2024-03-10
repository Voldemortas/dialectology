namespace dialectology.common;

public class Vector
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double I { get; private set; }
    public double J { get; private set; }

    public Vector(double x, double y, double i, double j)
    {
        X = x;
        Y = y;
        I = i;
        J = j;
    }

    public Vector(Point p, double i, double j)
    {
        X = p.X;
        Y = p.Y;
        I = i;
        J = j;
    }

}
