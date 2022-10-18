using FigureArea.Infrastructure;

namespace FigureArea.Figures;

public class Triangle : Figure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        CheckForTriangleInequality(a, b, c);

        A = a;
        B = b;
        C = c;
    }

    private void CheckForTriangleInequality(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException(Exceptions.TriangleInequalityException);
    }

    /// <summary>
    /// Get the area of the triangle
    /// </summary>
    /// <returns>Area of the triangle</returns>
    public override double GetArea()
    {
        var p = (A + B + C) / 2;
        var area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return area;
    }

    /// <summary>
    /// Check that the triangle is rectangular
    /// </summary>
    /// <returns>True - if triangle is rectangular, False - otherwise</returns>
    public bool IsRectangular()
    {
        var sortedSizes = new[] {A, B, C}
            .OrderBy(s => s)
            .ToArray();

        return Math.Abs(MathHelper.Square(sortedSizes[0]) + MathHelper.Square(sortedSizes[1]) -
                        MathHelper.Square(sortedSizes[2])) < Double.Epsilon;
    }
}