using MindBoxTest.Figures;

namespace Figures.Tests;

public class TriangleTest
{
    [TestCase(1, 0, 1)]
    [TestCase(-1, 1, 1)]
    [TestCase(2, 1, 1)]
    public void InvalidSides(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [TestCase(2, 2, 2, 1.73)]
    [TestCase(2, 3, 4, 2.90)]
    public void CalculateArea(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);

        Assert.That(expected, Is.EqualTo(triangle.Area).Within(0.01));
    }

    [TestCase(2, 2, 2, false)]
    [TestCase(3, 4, 5, true)]
    public void CalculateIsRigth(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);

        Assert.That(expected, Is.EqualTo(triangle.IsRight));
    }
}