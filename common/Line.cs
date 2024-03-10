namespace dialectology.common;

public class Line
{
    public Point A { get; private set; }
    public Point B { get; private set; }

    public Line(Point a, Point b)
    {
        A = a;
        B = b;
    }
    public Line(double x0, double y0, double x1, double y1)
    {
        A = new Point(x0, y0);
        B = new Point(x1, y1);
    }
}
