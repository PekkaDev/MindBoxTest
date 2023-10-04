namespace MindBoxTest.Figures;

public class Circle : FigureBase
{
    /// <summary>
    /// Circle radius
    /// </summary>
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;

        Validate();
    }

    protected override void Validate()
    {
        if (Radius <= 0)
        {
            throw new ArgumentException("Radius cannot be less than or equal to 0");
        }
    }

    protected override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}