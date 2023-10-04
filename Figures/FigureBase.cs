namespace MindBoxTest.Figures;

public abstract class FigureBase
{
    /// <summary>
    /// Area of the figure
    /// </summary>
    public double Area => _area.Value;

    private readonly Lazy<double> _area;

    protected FigureBase()
    {
        _area = new Lazy<double>(CalculateArea);
    }

    protected abstract void Validate();
    protected abstract double CalculateArea();
}