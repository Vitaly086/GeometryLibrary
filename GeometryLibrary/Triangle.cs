namespace GeometryLibrary;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        CheckTriangleValidity(sideA, sideB, sideC);

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) *
                         (semiPerimeter - _sideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        var a = sides[0];
        var b = sides[1];
        var hypotenuse = sides[2];

        return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2))) < double.Epsilon;
    }

    private void CheckTriangleValidity(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be positive");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("The provided dimensions do not form a triangle");
        }
    }
}