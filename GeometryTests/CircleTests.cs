namespace GeometryTests;

[TestFixture]
public class CircleTests
{
    [TestCase(5, ExpectedResult = 78.53981633974483)]
    [TestCase(10, ExpectedResult = 314.1592653589793)]
    public double CalculateArea_ValidRadius_ReturnsCorrectArea(double radius)
    {
        var circle = new Circle(radius);
        return circle.CalculateArea();
    }
    
    [TestCase(0)]
    [TestCase(-1)]
    public void CalculateArea_ZeroOrNegativeRadius_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius), $"Expected ArgumentException for radius: {radius}");
    }
}