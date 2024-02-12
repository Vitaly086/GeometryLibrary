namespace GeometryTests;

[TestFixture]
public class TriangleTests
{
    [TestCase(3, 4, 5, ExpectedResult = 6)]
    [TestCase(6, 8, 10, ExpectedResult = 24)]
    public double CalculateArea_ValidSides_ReturnsCorrectArea(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.CalculateArea();
    }

    [TestCase(0, 4, 5)]
    [TestCase(3, -4, 5)]
    [TestCase(3, 4, -5)]
    [TestCase(1, 1, 2)]
    public void CalculateArea_InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC),
            $"Expected ArgumentException for sides: {sideA}, {sideB}, {sideC}");
    }


    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(2, 3, 4, ExpectedResult = false)]
    [TestCase(6, 8, 10, ExpectedResult = true)]
    [TestCase(5, 12, 13, ExpectedResult = true)]
    public bool IsRightAngled_ValidTriangle_ReturnsCorrectResult(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.IsRightAngled();
    }
}