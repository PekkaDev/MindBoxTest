namespace MindBoxTest.Figures;

public class Triangle : FigureBase
{
    /// <summary>
    /// Lengths of triangle sides sorted in descending order
    /// </summary>
    public IReadOnlyList<double> Sides { get; }
    /// <summary>
    /// Is the triangle right
    /// </summary>
    public bool IsRight => _isRight.Value;

    private Lazy<bool> _isRight;

    public Triangle(double a, double b, double c)
    {
        var tempArr = new double[] { a, b, c };
        Array.Sort(tempArr, (a, b) => b.CompareTo(a));
        Sides = tempArr;

        _isRight = new Lazy<bool>(CalculateIsRight);

        Validate();
    }

    protected virtual bool CalculateIsRight()
    {
        return Sides[0] * Sides[0] == Sides[1] * Sides[1] + Sides[2] * Sides[2];
    }

    protected override void Validate()
    {
        if (Sides[2] <= 0)
        {
            throw new ArgumentException("Side length cannot be less than or equal to 0");
        }
        if (Sides[0] >= Sides[1] + Sides[2])
        {
            throw new ArgumentException("The length of the larger side of a triangle cannot be greater than or equal to the sum of the lengths of the two smaller sides.");
        }
    }

    protected override double CalculateArea()
    {
        var p = Sides.Sum() / 2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }
}