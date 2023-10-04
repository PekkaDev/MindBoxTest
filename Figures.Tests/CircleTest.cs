using MindBoxTest.Figures;

namespace Figures.Tests;

public class CircleTest
{
    [TestCase(-1)]
    [TestCase(0)]
    public void InvalidRadius(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [TestCase(1, 3.14)]
    [TestCase(2, 12.56)]
    public void CalculateArea(double radius, double expected)
    {
        var circle = new Circle(radius);

        Assert.That(expected, Is.EqualTo(circle.Area).Within(0.01));
    }
}