using FigureArea.Infrastructure;

namespace FigureArea.Domain.Figures;

public class Circle : Figure
{
    private readonly double _radius;

    double Radius
    {
        get => _radius;
        init
        {
            if (value < 0)
                throw new ArgumentException(ExceptionMessages.NegativeRadiusException);
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Get the area of the circle
    /// </summary>
    /// <returns>Area of the triangle</returns>
    public override double GetArea() =>
        Math.PI * MathHelper.Square(Radius);
}